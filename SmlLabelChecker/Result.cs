using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace SmlLabelChecker
{
    public partial class Result : Form
    {
        private readonly string _excelPath;
        private Setting.SettingData _settingData;

        public Result(string excelPath)
        {
            InitializeComponent();
            _excelPath = excelPath;
            LoadSettingsFromRegistry();
        }

        private void LoadSettingsFromRegistry()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\SmlLabelChecker"))
                {
                    if (key != null)
                    {
                        string jsonData = key.GetValue("SettingData")?.ToString();
                        if (!string.IsNullOrEmpty(jsonData))
                        {
                            _settingData = JsonConvert.DeserializeObject<Setting.SettingData>(jsonData);
                        }
                    }
                }
                if (_settingData == null)
                {
                    _settingData = new Setting.SettingData { UrineSet = false, Labels = new List<Setting.LabelData>() };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"설정 로드 중 오류: {ex.Message}");
            }
        }

        private void InitializeDataGridView()
        {
            LabelResultView.Columns.Add("ReceptionNumber", "접수번호");
            LabelResultView.Columns.Add("Hospital", "병원");
            LabelResultView.Columns.Add("Name", "이름");
            LabelResultView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "TestItems",
                HeaderText = "검사항목",
                Text = "보기",
                UseColumnTextForButtonValue = true
            });
            LabelResultView.Columns.Add("ReceivedSampleCount", "접수된 검체 수");
            LabelResultView.Columns.Add("UseLabelCount", "사용한 라벨 수");
            LabelResultView.Columns.Add("Result", "오차");
            LabelResultView.Columns.Add("Etc", "특이사항");

            LabelResultView.Columns[0].Width = 95;
            LabelResultView.Columns[1].Width = 168;
            LabelResultView.Columns[2].Width = 110;
            LabelResultView.Columns[3].Width = 110;
            LabelResultView.Columns[4].Width = 56;
            LabelResultView.Columns[5].Width = 56;
            LabelResultView.Columns[6].Width = 156;
            LabelResultView.Columns[7].Width = 444;

            LabelResultView.Columns[0].DefaultCellStyle.Font = new Font(LabelResultView.Font, FontStyle.Bold);
            LabelResultView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LabelResultView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LabelResultView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LabelResultView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            LabelResultView.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
            LabelResultView.RowHeadersVisible = false;
            LabelResultView.CellClick += LabelResultView_CellClick;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            string errorMessage = string.Empty;
            string applyDate = string.Empty;

            if (ReceptionHistory.Read(_excelPath, out errorMessage, out applyDate))
            {
                LabelInfo.Foreach((number, useLabelCount) =>
                {
                    var item = ReceptionHistory.Find(number);
                    int receivedSampleCount = 0;
                    int hospital = 0;
                    string name = "";
                    List<string> etcText = new List<string>();

                    if (item != null)
                    {
                        receivedSampleCount = item.ReceivedSampleCount;
                        hospital = item.Hospital.Code;
                        name = item.Name;

                        if (_settingData.UrineSet)
                        {
                            receivedSampleCount = CalculateUrineLabelCount(receivedSampleCount, item);
                            if (receivedSampleCount != item.ReceivedSampleCount)
                            {
                                etcText.Add("Urine 항목 분리 적용됨. ");
                            }
                        }
                        receivedSampleCount = AdjustLabelCountBasedOnSettings(receivedSampleCount, item, etcText);
                    }
                    else
                    {
                        etcText.Add("접수 내역이 없습니다.");
                    }

                    int resultLabel = useLabelCount - receivedSampleCount;
                    string resultLabelMessage = resultLabel > 0
                        ? $"{Math.Abs(resultLabel)}개를 더 사용"
                        : (resultLabel < 0
                            ? $"{Math.Abs(resultLabel)}개를 사용하지 않음"
                            : "통과");

                    string resultEtc = Util.FormatEtcText(etcText);
                    
                    int rowIndex = LabelResultView.Rows.Add(
                        number,
                        item==null?"":item.Hospital.Name+"("+item.Hospital.Code+")",
                        name,
                        "보기",
                        receivedSampleCount,
                        useLabelCount,
                        resultLabelMessage,
                        resultEtc
                    );
                    
                    if (!string.IsNullOrEmpty(resultEtc))
                    {
                        LabelResultView.Rows[rowIndex].Height = Math.Max(22, 22 * etcText.Count);
                    }

                    if (item == null)
                    {
                        LabelResultView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                        LabelResultView.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (resultLabel == 0)
                    {
                        LabelResultView.Rows[rowIndex].Cells[6].Style.ForeColor = Color.Blue;
                    }

                    if (resultLabel != 0)
                    {
                        Font currentFont = LabelResultView.Rows[rowIndex].Cells[6].Style.Font ?? LabelResultView.Font;
                        LabelResultView.Rows[rowIndex].Cells[6].Style.Font = new Font(currentFont.FontFamily,
                            currentFont.Size, FontStyle.Bold);
                        LabelResultView.Rows[rowIndex].Cells[6].Style.ForeColor = Color.Red;
                    }
                });

                ReceptionHistory.Foreach(item =>
                {
                    if (LabelInfo.Find(item.ReceptionNumber) == -1)
                    {
                        int adjustedLabelCount = 0;

                        // Apply UrineSet and LabelData adjustments for unmatched items
                        int receivedSampleCount = item.ReceivedSampleCount;
                        List<string> etcText = new List<string>();
                        if (_settingData.UrineSet)
                        {
                            receivedSampleCount = CalculateUrineLabelCount(receivedSampleCount, item);
                            if (receivedSampleCount != item.ReceivedSampleCount)
                            {
                                etcText.Add("Urine 항목 분리 적용됨.");
                            }
                        }

                        receivedSampleCount = AdjustLabelCountBasedOnSettings(receivedSampleCount, item, etcText);

                        int error = adjustedLabelCount - receivedSampleCount;
                        string resultLabelMessage = error > 0
                            ? $"{Math.Abs(error)}개를 더 사용"
                            : (error < 0 ? $"{Math.Abs(error)}개를 사용하지 않음" : "통과");

                        string resultEtc = "라벨 사용 내역이 없습니다.\n" + Util.FormatEtcText(etcText);
                        
                        int rowIndex = LabelResultView.Rows.Add(
                            item.ReceptionNumber,
                            item.Hospital.Name+"("+item.Hospital.Code+")",
                            item.Name,
                            "보기",
                            receivedSampleCount,
                            adjustedLabelCount,
                            resultLabelMessage,
                            resultEtc
                        );

                        LabelResultView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Indigo;
                        LabelResultView.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

                        if (error == 0)
                        {
                            LabelResultView.Rows[rowIndex].Cells[6].Style.ForeColor = Color.Blue;
                        }

                        if (error != 0)
                        {
                            Font currentFont = LabelResultView.Rows[rowIndex].Cells[6].Style.Font ??
                                               LabelResultView.Font;
                            LabelResultView.Rows[rowIndex].Cells[6].Style.Font = new Font(currentFont.FontFamily,
                                currentFont.Size, FontStyle.Bold);
                            LabelResultView.Rows[rowIndex].Cells[6].Style.ForeColor = Color.Red;
                        }
                    }
                });

                DateLabel.Text = Util.FormatDateString(Util.ParseDateToTuple(applyDate));
            }
            else
            {
                MessageBox.Show(errorMessage, "다시 시작해 주세요", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private int AdjustLabelCountBasedOnSettings(int receivedSampleCount, ReceptionItem item, List<string> etcText)
        {
            if (item == null || item.TestItem == null || item.TestItem.Count == 0 || _settingData.Labels == null ||
                _settingData.Labels.Count == 0)
                return receivedSampleCount;

            int adjustedCount = receivedSampleCount;

            foreach (var labelSetting in _settingData.Labels)
            {
                // HospitalCode가 0이면 모든 병원에 적용
                if (labelSetting.HospitalCode == 0 || labelSetting.HospitalCode == item.Hospital.Code)
                {
                    foreach (var test in item.TestItem)
                    {
                        if (test.TestCode == labelSetting.TestCode)
                        {
                            if (labelSetting.SettingLabel == 0)
                            {
                                adjustedCount -= 1;
                            }
                            else
                            {
                                adjustedCount += labelSetting.SettingLabel - 1;
                            }
                            etcText.Add($"병원 {item.Hospital.Code}의 " +  $"{labelSetting.TestCode}항목에 대해 {labelSetting.SettingLabel}개 라벨 설정 적용됨. ");
                            break;
                        }
                    }
                }
            }

            return adjustedCount;
        }

        private int CalculateUrineLabelCount(int adjustedLabelCount,ReceptionItem item)
        {
            if (item == null || item.TestItem == null || item.TestItem.Count == 0)
                return adjustedLabelCount;

            HashSet<int> specialUrineCodes = new HashSet<int>
                { 70178, 70182, 70253, 70261, 77142, 77143, 77150, 77151, 77161 };
            HashSet<int> urineDailyCodes = new HashSet<int>
                { 70000, 70004, 70005, 70006, 77560, 77561, 77562, 77563, 70015, 77566 };
            HashSet<int> nmpCode = new HashSet<int> { 27541 };

            bool hasSpecialUrine = false; // 특수 Urine 항목 존재 여부
            bool hasDailyUrine = false; // 요일반 및 요침사 존재 여부
            bool hasNmp = false; // npm 존재 여부
            bool hasOtherUrine = false; // 기타 Random Urine 존재 여부

            foreach (var test in item.TestItem)
            {
                bool isUrine = test.SpecimenName.ToLower().Contains("random urine");

                if (isUrine)
                {
                    if (specialUrineCodes.Contains(test.TestCode))
                    {
                        hasSpecialUrine = true; // 특수 Urine 항목 발견
                    }
                    else if (urineDailyCodes.Contains(test.TestCode))
                    {
                        hasDailyUrine = true; // 요일반 및 요침사 발견
                    }
                    else if (nmpCode.Contains(test.TestCode))
                    {
                        hasNmp = true; // npm 발견
                    }
                    else
                    {
                        hasOtherUrine = true; // 나머지 Random Urine 발견
                    }
                }
            }

            // 검체 수 조정
            int totalLabelCount = adjustedLabelCount;

            // 요구 사항 1: 미생물 유린 항목이 있으면 검체수 -1
            if (hasSpecialUrine)
                totalLabelCount--;

            // 요구 사항 2: 나머지 유린이 있다면 검체수 -1
            if (hasDailyUrine || hasNmp || hasOtherUrine)
                totalLabelCount--;
            
            // 항목 코드별 라벨 수 계산
            if (hasSpecialUrine) totalLabelCount++;
            if (hasDailyUrine) totalLabelCount++;
            if (hasNmp) totalLabelCount++;
            if (hasOtherUrine) totalLabelCount++;

            return Math.Max(totalLabelCount, 0);
        }


        private void LabelResultView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                int receptionNumber = Convert.ToInt32(LabelResultView.Rows[e.RowIndex].Cells[0].Value);
                var item = ReceptionHistory.Find(receptionNumber);

                if (item != null && item.TestItem.Count > 0)
                {
                    StringBuilder testItemsMessage = new StringBuilder("검사항목 목록:\n");
                    foreach (var test in item.TestItem)
                    {
                        testItemsMessage.AppendLine($" - {test.TestName} ({test.SpecimenName})");
                    }
                    MessageBox.Show(testItemsMessage.ToString(), $"접수번호 {receptionNumber}의 검사항목", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("검사항목이 없습니다.", $"접수번호 {receptionNumber}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}