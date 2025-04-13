using System;
using System.Windows.Forms;

namespace SmlLabelChecker
{
    public partial class SearchResultPanel : UserControl
    {
        private int code;
        private Action<int> codeResult;
        public SearchResultPanel(Action<int> codeResult)
        {
            this.codeResult = codeResult;
            InitializeComponent();
            
            // 컨트롤 전체에 클릭 이벤트 연결
            this.MouseClick += new MouseEventHandler(SearchResultPanel_MouseClick);

            // 자식 컨트롤의 클릭 이벤트를 부모로 전달하도록 설정
            pictureBox1.MouseClick += (s, e) => this.OnMouseClick(e);
            testCodeLabel.MouseClick += (s, e) => this.OnMouseClick(e);
            testNameLabel.MouseClick += (s, e) => this.OnMouseClick(e);

            // 커서가 Hand로 설정되어 있으므로 클릭 가능함을 시각적으로 표시
            this.Cursor = Cursors.Hand;
        }

        private void SearchResultPanel_MouseClick(object sender, MouseEventArgs e)
        {
            codeResult?.Invoke(code);
        }
        
        public void Set(int testCode, string testName)
        {
            code = testCode;
            testCodeLabel.Text = code.ToString();
            testNameLabel.Text = testName;
        }
    }
}