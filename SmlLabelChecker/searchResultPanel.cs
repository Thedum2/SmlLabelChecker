using System;
using System.Windows.Forms;

namespace SmlLabelChecker
{
    public partial class SearchResultPanel : UserControl
    {
        public SearchResultPanel()
        {
            InitializeComponent();
        }

        public void Set(string testCode, string testName)
        {
            testCodeLabel.Text = testCode;
            testNameLabel.Text = testName;
        }
    }
}