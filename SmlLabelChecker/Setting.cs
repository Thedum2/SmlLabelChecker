using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace SmlLabelChecker
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            LabelSettingDrop.SelectedIndex = 0;
            LoadFromRegistry();
        }

        private void LoadFromRegistry()
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
                            SettingData data = JsonConvert.DeserializeObject<SettingData>(jsonData);
                            RefreshDataView(data.Labels);
                            UrineSetting.Checked = data.UrineSet; // 공통 UrineSet 로드
                        }
                    }
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($@"JSON 파싱 오류: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"오류 발생: {ex.Message}");
            }
        }

        private void SaveToRegistry(SettingData settingData)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(settingData);
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\SmlLabelChecker"))
                {
                    if (key != null)
                    {
                        key.SetValue("SettingData", jsonData, RegistryValueKind.String);
                    }
                }
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"JSON 처리 오류: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
        }

        private bool CheckDuplicateTestCode(SettingData settingData, int hospitalCode, int testCode)
        {
            // 모든 병원(HospitalCode == 0)에 대해 동일한 testCode가 이미 존재하는지 확인
            bool commonExists = settingData.Labels.Exists(data => 
                data.HospitalCode == 0 && data.TestCode == testCode);

            // 개별 병원에 대해 동일한 testCode가 이미 존재하는지 확인
            bool specificExists = settingData.Labels.Exists(data => 
                data.HospitalCode == hospitalCode && data.TestCode == testCode && hospitalCode != 0);

            // 1. 모든 병원에 이미 등록된 경우, 개별 병원 등록 불가
            if (hospitalCode != 0 && commonExists)
            {
                MessageBox.Show("이미 모든 병원에 대해 해당 테스트 코드가 등록되어 있어 개별 병원 설정을 추가할 수 없습니다.");
                return true;
            }

            // 2. 동일한 병원에 이미 등록된 경우
            if (specificExists)
            {
                MessageBox.Show("해당 병원에 이미 동일한 테스트 코드가 등록되어 있습니다.");
                return true;
            }

            return false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int hospitalCode = Convert.ToInt32(HospitalTextBox.Text);
                int testCode = Convert.ToInt32(TestCodeTextBox.Text);
                int settingLabel = LabelSettingDrop.SelectedIndex == 0 ? 0 : LabelSettingDrop.SelectedIndex + 1;

                // 기존 데이터 로드
                SettingData settingData = LoadSettingDataFromRegistry();
                if (settingData == null)
                {
                    settingData = new SettingData { UrineSet = UrineSetting.Checked, Labels = new List<LabelData>() };
                }

                // 중복 테스트 코드 확인
                if (CheckDuplicateTestCode(settingData, hospitalCode, testCode))
                {
                    return;
                }

                // 모든 병원(hospitalCode == 0)에 대해 등록 시, 기존 개별 병원 설정 제거
                if (hospitalCode == 0)
                {
                    settingData.Labels.RemoveAll(data => 
                        data.TestCode == testCode && data.HospitalCode != 0);
                }

                // 새 항목 추가
                settingData.Labels.Add(new LabelData
                {
                    HospitalCode = hospitalCode,
                    TestCode = testCode,
                    SettingLabel = settingLabel
                });

                SaveToRegistry(settingData);
                RefreshDataView(settingData.Labels);

                HospitalTextBox.Text = "";
                TestCodeTextBox.Text = "";
                LabelSettingDrop.SelectedIndex = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("숫자를 입력해주세요.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
        }

        private SettingData LoadSettingDataFromRegistry()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\SmlLabelChecker"))
            {
                if (key != null)
                {
                    string jsonData = key.GetValue("SettingData")?.ToString();
                    if (!string.IsNullOrEmpty(jsonData))
                    {
                        return JsonConvert.DeserializeObject<SettingData>(jsonData);
                    }
                }
            }
            return null;
        }

        public void RefreshDataView(List<LabelData> labels = null)
        {
            try
            {
                if (labels == null)
                {
                    SettingData data = LoadSettingDataFromRegistry();
                    labels = data?.Labels;
                }

                LabelSettingDataView_Common.Items.Clear();
                LabelSettingDataView_Etc.Items.Clear();
                if (labels != null && labels.Count > 0)
                {
                    foreach (var data in labels)
                    {
                        bool isCommon = data.HospitalCode == 0;
                        string message = isCommon
                            ? $"모든병원에서는 {data.TestCode}코드의 검사를 진행 시, 라벨을 {data.SettingLabel}개를 사용합니다."
                            : $"{data.HospitalCode}병원에서는 {data.TestCode}코드의 검사를 진행 시, 라벨을 {data.SettingLabel}개를 사용합니다.";

                        if (isCommon)
                        {
                            LabelSettingDataView_Common.Items.Add(new ListBoxItem(data, message));
                        }
                        else
                        {
                            LabelSettingDataView_Etc.Items.Add(new ListBoxItem(data, message));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 뷰 갱신 오류: {ex.Message}");
            }
        }

        private void DeleteButton_Etc_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabelSettingDataView_Etc.SelectedItem == null)
                {
                    MessageBox.Show("삭제할 항목을 선택해주세요.");
                    return;
                }

                ListBoxItem selectedItem = (ListBoxItem)LabelSettingDataView_Etc.SelectedItem;
                LabelData selectedData = selectedItem.Data;

                SettingData settingData = LoadSettingDataFromRegistry();
                if (settingData != null)
                {
                    settingData.Labels.RemoveAll(data =>
                        data.HospitalCode == selectedData.HospitalCode &&
                        data.TestCode == selectedData.TestCode &&
                        data.SettingLabel == selectedData.SettingLabel);

                    SaveToRegistry(settingData);
                    RefreshDataView(settingData.Labels);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 중 오류 발생: {ex.Message}");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LabelSettingDataView_Common.SelectedItem == null)
                {
                    MessageBox.Show("삭제할 항목을 선택해주세요.");
                    return;
                }

                ListBoxItem selectedItem = (ListBoxItem)LabelSettingDataView_Common.SelectedItem;
                LabelData selectedData = selectedItem.Data;

                SettingData settingData = LoadSettingDataFromRegistry();
                if (settingData != null)
                {
                    settingData.Labels.RemoveAll(data =>
                        data.HospitalCode == selectedData.HospitalCode &&
                        data.TestCode == selectedData.TestCode &&
                        data.SettingLabel == selectedData.SettingLabel);

                    SaveToRegistry(settingData);
                    RefreshDataView(settingData.Labels);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 중 오류 발생: {ex.Message}");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 새로운 데이터 클래스 정의
        public class SettingData
        {
            public bool UrineSet { get; set; } // 공통 설정
            public List<LabelData> Labels { get; set; } // 리스트로 관리
        }

        public class LabelData
        {
            public int HospitalCode { get; set; }
            public int TestCode { get; set; }
            public int SettingLabel { get; set; }
        }

        public class ListBoxItem
        {
            public LabelData Data { get; }
            public string DisplayText { get; }

            public ListBoxItem(LabelData data, string displayText)
            {
                Data = data;
                DisplayText = displayText;
            }

            public override string ToString() => DisplayText;
        }

        private void SearchResultPanel_Click(int code)
        {
            TestCodeTextBox.Text = code.ToString();
            resultContainer.Visible = false;
        }

        private void TestCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TestCodeTextBox.TextLength > 1)
            {
                resultContainer.Controls.Clear();
                List<TestListData.Test> tests = TestListData.Search(TestCodeTextBox.Text);

                if (tests.Count > 0)
                {
                    resultContainer.Visible = true;

                    foreach (var test in tests)
                    {
                        SearchResultPanel panel = new SearchResultPanel(SearchResultPanel_Click);
                        panel.Set(test.TestCode, test.TestName);
                        resultContainer.Controls.Add(panel);
                    }

                    int calcCount = tests.Count > 5 ? 5 : tests.Count;
                    resultContainer.Height = newHeight(calcCount);
                }
                else
                {
                    resultContainer.Visible = false;
                }
            }
            else
            {
                resultContainer.Controls.Clear();
                resultContainer.Visible = false;
            }

            int newHeight(int testCount)
            {
                int blank = 3;
                int panelHeight = 46;
                return (panelHeight + blank * 2) * testCount;
            }
        }

        private void UrinSettingInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "이 옵션을 활성화하면 동일한 Urine 검체로 접수된 경우에도,\n요일반 및 요침사 항목(70000, 70004, 70005, 70006, 77560, 77561, 77562, 77563, 70015, 77566),\n기타 Urine 항목,\nNmp(27541)이 각각 별도로 처리됩니다.",
                "Urine 설정 정보",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void UrineSetting_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SettingData settingData = LoadSettingDataFromRegistry();
                if (settingData == null)
                {
                    settingData = new SettingData { UrineSet = UrineSetting.Checked, Labels = new List<LabelData>() };
                }

                settingData.UrineSet = UrineSetting.Checked;
                SaveToRegistry(settingData);
                RefreshDataView(settingData.Labels); // UI 갱신
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Urine 설정 저장 중 오류 발생: {ex.Message}");
            }
        }
    }
}