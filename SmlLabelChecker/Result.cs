using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace SmlLabelChecker
{
    public partial class Result : Form
    {
        private readonly string _excelPath;

        public Result(string excelPath)
        {
            InitializeComponent();
            _excelPath = excelPath;
        }

        private void InitializeDataGridView()
        {
            // 열 추가
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

            // 열 너비 설정
            LabelResultView.Columns[0].Width = 95;
            LabelResultView.Columns[1].Width = 168;
            LabelResultView.Columns[2].Width = 110;
            LabelResultView.Columns[3].Width = 110;
            LabelResultView.Columns[4].Width = 56;
            LabelResultView.Columns[5].Width = 56;
            LabelResultView.Columns[6].Width = 156;
            LabelResultView.Columns[7].Width = 444;

            // 0번 열: Bold + 중간 정렬
            LabelResultView.Columns[0].DefaultCellStyle.Font = new Font(LabelResultView.Font, FontStyle.Bold);
            LabelResultView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 4, 5, 6번 열: 중간 정렬
            LabelResultView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LabelResultView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LabelResultView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; ;

            // 행 머리글 숨기기 (옵션)
            LabelResultView.RowHeadersVisible = false;

            LabelResultView.CellClick += LabelResultView_CellClick;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            string errorMessage = string.Empty;
            string applyDate = string.Empty;
            
            // 엑셀 파일 읽기
            if (ReceptionHistory.Read(_excelPath, out errorMessage, out applyDate))
            {
                // LabelInfo를 기준으로 데이터 채우기
                LabelInfo.Foreach((number, useLabelCount) =>
                {
                    var item = ReceptionHistory.Find(number); // 해당 접수번호가 ReceptionHistory에 있는지 확인
                    int receivedSampleCount = 0;
                    int resultLabel = 0;
                    string hospital = "";
                    string name = "";
                    string etcText = "";

                    if (item != null)
                    {
                        receivedSampleCount = item.ReceivedSampleCount;
                        hospital = item.Hospital;
                        name = item.Name;
                        resultLabel = useLabelCount - receivedSampleCount;
                    }
                    else
                    {
                        resultLabel = -useLabelCount;
                        etcText = "접수 내역이 없습니다.";
                    }

                    
                    string resultLabelMessage = resultLabel > 0 
                        ? $"{Math.Abs(resultLabel)}개를 더 사용" 
                        : (resultLabel < 0 
                            ? $"{Math.Abs(resultLabel)}개를 사용하지 않음" 
                            : "통과");
                    
                    // 행 추가
                    int rowIndex = LabelResultView.Rows.Add(
                        number, // 접수번호
                        hospital, // 병원
                        name, // 이름
                        "보기", // 검사항목 버튼
                        receivedSampleCount, // 접수된 검체 수
                        useLabelCount, // 사용한 라벨 수
                        resultLabelMessage, // 오차
                        etcText // 특이사항
                    );

                    // 배경색 설정 (기존 로직 유지)
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
                        LabelResultView.Rows[rowIndex].Cells[6].Style.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold);
                        LabelResultView.Rows[rowIndex].Cells[6].Style.ForeColor = Color.Red;
                    }
                });

                // ReceptionHistory에만 있는 데이터 추가 (LabelInfo에 없는 경우)
                ReceptionHistory.Foreach(item =>
                {
                    if (LabelInfo.Find(item.ReceptionNumber) == -1) // LabelInfo에 없는 접수번호만
                    {
                        int error = item.ReceivedSampleCount; // 오차 = 접수된 검체 수
                        int rowIndex = LabelResultView.Rows.Add(
                            item.ReceptionNumber,
                            item.Hospital,
                            item.Name,
                            "보기",
                            item.ReceivedSampleCount,
                            "", // 사용한 라벨 수 없음
                            error,
                            "라벨 사용 내역이 없습니다."
                        );

                        // 배경색 설정 (기존 로직 유지)
                        LabelResultView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Indigo;
                        LabelResultView.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
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

        private void LabelResultView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 검사항목 버튼 클릭 처리 (열 인덱스 3)
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                // 해당 행의 접수번호 가져오기
                int receptionNumber = Convert.ToInt32(LabelResultView.Rows[e.RowIndex].Cells[0].Value);
                var item = ReceptionHistory.Find(receptionNumber);

                if (item != null && item.TestItem.Count > 0)
                {
                    // 검사 항목 목록을 문자열로 구성
                    StringBuilder testItemsMessage = new StringBuilder("검사항목 목록:\n");
                    foreach (var test in item.TestItem)
                    {
                        testItemsMessage.AppendLine($" - {test.TestName} ({test.SpecimenName})");
                    }

                    // MessageBox로 표시
                    MessageBox.Show(testItemsMessage.ToString(), $"접수번호 {receptionNumber}의 검사항목", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("검사항목이 없습니다.", $"접수번호 {receptionNumber}", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}