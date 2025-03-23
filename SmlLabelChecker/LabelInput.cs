using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SmlLabelChecker
{
    public partial class LabelInput : Form
    {
        private string _excelPath;
        private int _currentNumber;
        //임시 처리 개발용
        System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        public LabelInput(string excelPath, string start, string end)
        {
            InitializeComponent();
            _excelPath = excelPath;

            LabelInfo._start = Convert.ToInt32(start);
            LabelInfo._end = Convert.ToInt32(end);
            
            _currentNumber = LabelInfo._start;
            StartNumber.Text = @"시작 : " + start;
            EndNumber.Text = @"종료 : " + end;
            UpdateLabel();
            
            //임시 처리 개발용
            Random random = new Random();
            _timer.Interval = 1; // 0.1초 = 100ms
            _timer.Tick += (s, e) => 
            {
                int randomNumber = random.Next(0, 8); // 0~7 사이의 랜덤 숫자
                PressLabel(randomNumber);
            };
            _timer.Start();
        }
        
        private void UpdateLabel()
        {
            int remain = LabelInfo.Find(_currentNumber);
            
            if (remain == -1)
            {
                NumberLabel.Text = $@"{_currentNumber} (미입력)";
            }
            else
            {
                NumberLabel.Text = $@"{_currentNumber} ({remain}개 사용)";
            }
            RemainNumber.Text = @"남은 라벨 : " + (LabelInfo._end - _currentNumber);
        }
        
        private void Previous_Click(object sender, EventArgs e)
        {
            if (_currentNumber == LabelInfo._start)
            {
                MessageBox.Show("이미 첫 번호입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _currentNumber--;
                UpdateLabel();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (_currentNumber == LabelInfo._end)
            {
                MessageBox.Show("마지막 번호입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _currentNumber++;
                UpdateLabel();
            }
        }

        private void PressLabel(int num)
        {

            if (num > 8 || num < 0)
            {
                MessageBox.Show("올바른 개수를 입력하세요");
                return;
            }

            LabelInfo.Apply(_currentNumber, num);
            UpdateLabel();
            
            
            if (_currentNumber == LabelInfo._end)
            {
                //임시 처리 개발용
                _timer.Stop();
                
                DialogResult result = MessageBox.Show("마지막 번호입니다. 확정하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    OpenNextForm();
                }
            }
            else
            {
                _currentNumber++;
                UpdateLabel();
            }
        }
        
        private void OpenNextForm()
        {
            int[] missingNumbers = ValidateCheck(LabelInfo._start, LabelInfo._end);

            if (missingNumbers.Length == 0)
            {
                Result result = new Result(_excelPath);
                result.FormClosed += (s, args) => Application.Exit();
                result.Show();
                Hide();
            }
            else
            {
                string message = missingNumbers.Length+"개의 번호가 입력되지 않았습니다: \n" + string.Join(", ", missingNumbers);
                MessageBox.Show(message);
            }
        }


        private void Button_0_Click(object sender, EventArgs e)
        {
            PressLabel(0);
        }
        private void Button_1_Click(object sender, EventArgs e)
        {
            PressLabel(1);
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            PressLabel(2);
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            PressLabel(3);
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            PressLabel(4);
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            PressLabel(5);
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            PressLabel(6);
        }
        private void Button_7_Click(object sender, EventArgs e)
        {
            PressLabel(7);
        }
        private void LabelInput_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    PressLabel(0);
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    PressLabel(1);
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    PressLabel(2);
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    PressLabel(3);
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    PressLabel(4);
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    PressLabel(5);
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    PressLabel(6);
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    PressLabel(7);
                    break;
                default:
                    PressLabel(-1);
                    break;
            }
        }

        private int[] ValidateCheck(int start, int end)
        {
            
            List<int> missingNumbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                int useLabelCount = LabelInfo.Find(i);

                if (useLabelCount == -1)
                {
                    missingNumbers.Add(i);
                }
            }
            
            return missingNumbers.ToArray();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            OpenNextForm();
        }
    }
}
