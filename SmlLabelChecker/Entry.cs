using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SmlLabelChecker
{
    public partial class Entry : Form
    {
        private string _excelPath;

        public Entry()
        {
            InitializeComponent();
            var txtList = new TextBox[] { LabelStart, LabelEnd };

            // Placeholder 설정
            foreach (var txt in txtList)
            {
                txt.Enter += TextBox_Enter;
                txt.Leave += TextBox_Leave;
                SetPlaceholder(txt);
            }
        }

        private void SetPlaceholder(TextBox textBox)
        {
            string placeholder = textBox == LabelStart ? "시작" : "종료";
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray; // Placeholder 색상
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black; // 기본 색상
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetPlaceholder(textBox);
            }
        }

        private void SearchExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*";
                openFileDialog.Title = "엑셀 파일 선택";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _excelPath = openFileDialog.FileName;

                    // 파일 확장자 체크
                    if (Path.GetExtension(_excelPath).ToLower() != ".xls" && Path.GetExtension(_excelPath).ToLower() != ".xlsx")
                    {
                        MessageBox.Show("엑셀 파일이 아닙니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 엑셀 파일 이름을 ExcelPath 라벨에 표시
                    string fileName = Path.GetFileName(_excelPath);
                    ExcelPath.Text = fileName; // ExcelPath 라벨에 파일 이름 설정
                    ExcelPath.ForeColor = Color.Black; // 라벨 색상 변경
                }
                else
                {
                    // 파일이 선택되지 않은 경우
                    ExcelPath.Text = "엑셀 파일이 없습니다."; // 라벨에 메시지 설정
                    ExcelPath.ForeColor = Color.Gray; // 라벨 색상 변경
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // 1. 엑셀 파일 존재 여부 체크
            if (string.IsNullOrEmpty(_excelPath) || 
                (Path.GetExtension(_excelPath).ToLower() != ".xls" && 
                 Path.GetExtension(_excelPath).ToLower() != ".xlsx"))
            {
                MessageBox.Show("엑셀 파일이 없거나 올바른 엑셀 파일이 아닙니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. 시작과 종료 입력값 체크
            if (LabelStart.ForeColor == Color.Gray || LabelEnd.ForeColor == Color.Gray ||
                string.IsNullOrWhiteSpace(LabelStart.Text) || string.IsNullOrWhiteSpace(LabelEnd.Text))
            {
                MessageBox.Show("시작 또는 종료 값을 올바르게 입력해 주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. 시작과 종료 값 비교 체크
            if (int.TryParse(LabelStart.Text, out int startValue) &&
                int.TryParse(LabelEnd.Text, out int endValue))
            {
                if (startValue > endValue)
                {
                    MessageBox.Show("시작 값은 종료 값보다 작아야 합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("시작 및 종료 값은 숫자여야 합니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. LabelInput 폼을 열고 현재 폼 종료
            LabelInput labelInput = new LabelInput(_excelPath, LabelStart.Text, LabelEnd.Text);
            labelInput.FormClosed += (s, args) => Application.Exit();
            labelInput.Show();
            this.Hide();
        }


        private void Setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }
    }
}
