namespace SmlLabelChecker
{
    partial class Entry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.Entry_Main1 = new System.Windows.Forms.Label();
            this.SearchExcel = new System.Windows.Forms.Button();
            this.ExcelPath = new System.Windows.Forms.TextBox();
            this.Entry_Main2 = new System.Windows.Forms.Label();
            this.LabelStart = new System.Windows.Forms.TextBox();
            this.LabelEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entry_Main1
            // 
            this.Entry_Main1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Entry_Main1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Entry_Main1.Location = new System.Drawing.Point(12, 9);
            this.Entry_Main1.Name = "Entry_Main1";
            this.Entry_Main1.Size = new System.Drawing.Size(296, 28);
            this.Entry_Main1.TabIndex = 0;
            this.Entry_Main1.Text = "접수한 엑셀을 입력하세요";
            this.Entry_Main1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchExcel
            // 
            this.SearchExcel.Location = new System.Drawing.Point(186, 45);
            this.SearchExcel.Name = "SearchExcel";
            this.SearchExcel.Size = new System.Drawing.Size(122, 25);
            this.SearchExcel.TabIndex = 1;
            this.SearchExcel.Text = "찾아보기";
            this.SearchExcel.UseVisualStyleBackColor = true;
            this.SearchExcel.Click += new System.EventHandler(this.SearchExcel_Click);
            // 
            // ExcelPath
            // 
            this.ExcelPath.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExcelPath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ExcelPath.Location = new System.Drawing.Point(12, 45);
            this.ExcelPath.Name = "ExcelPath";
            this.ExcelPath.Size = new System.Drawing.Size(164, 25);
            this.ExcelPath.TabIndex = 2;
            this.ExcelPath.Text = "...";
            // 
            // Entry_Main2
            // 
            this.Entry_Main2.BackColor = System.Drawing.Color.MistyRose;
            this.Entry_Main2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Entry_Main2.Location = new System.Drawing.Point(12, 83);
            this.Entry_Main2.Name = "Entry_Main2";
            this.Entry_Main2.Size = new System.Drawing.Size(296, 28);
            this.Entry_Main2.TabIndex = 3;
            this.Entry_Main2.Text = "사용한 번호를 입력하세요";
            this.Entry_Main2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelStart
            // 
            this.LabelStart.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelStart.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LabelStart.Location = new System.Drawing.Point(16, 116);
            this.LabelStart.Name = "LabelStart";
            this.LabelStart.Size = new System.Drawing.Size(127, 25);
            this.LabelStart.TabIndex = 4;
            this.LabelStart.Text = "시작";
            this.LabelStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelEnd
            // 
            this.LabelEnd.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelEnd.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LabelEnd.Location = new System.Drawing.Point(181, 116);
            this.LabelEnd.Name = "LabelEnd";
            this.LabelEnd.Size = new System.Drawing.Size(127, 25);
            this.LabelEnd.TabIndex = 5;
            this.LabelEnd.Text = "종료";
            this.LabelEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(150, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "~";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(162, 156);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(146, 30);
            this.Start.TabIndex = 7;
            this.Start.Text = "시작하기";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "※2일 이상의 접수내역 사용 불가";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Setting
            // 
            this.Setting.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Setting.Location = new System.Drawing.Point(10, 156);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(146, 30);
            this.Setting.TabIndex = 9;
            this.Setting.Text = "설정하기";
            this.Setting.UseVisualStyleBackColor = true;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(318, 213);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelEnd);
            this.Controls.Add(this.LabelStart);
            this.Controls.Add(this.Entry_Main2);
            this.Controls.Add(this.ExcelPath);
            this.Controls.Add(this.SearchExcel);
            this.Controls.Add(this.Entry_Main1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Entry";
            this.Text = "라벨 검토 프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Setting;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button Start;

        private System.Windows.Forms.Label Entry_Main2;
        private System.Windows.Forms.TextBox LabelStart;
        private System.Windows.Forms.TextBox LabelEnd;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button SearchExcel;
        private System.Windows.Forms.TextBox ExcelPath;

        private System.Windows.Forms.Label Entry_Main1;

        #endregion
    }
}