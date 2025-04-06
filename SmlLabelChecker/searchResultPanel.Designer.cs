using System.ComponentModel;

namespace SmlLabelChecker
{
    partial class SearchResultPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testCodeLabel = new System.Windows.Forms.Label();
            this.testNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // testCodeLabel
            // 
            this.testCodeLabel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.testCodeLabel.Location = new System.Drawing.Point(43, 3);
            this.testCodeLabel.Name = "testCodeLabel";
            this.testCodeLabel.Size = new System.Drawing.Size(141, 24);
            this.testCodeLabel.TabIndex = 1;
            this.testCodeLabel.Text = "90046";
            this.testCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // testNameLabel
            // 
            this.testNameLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.testNameLabel.Location = new System.Drawing.Point(43, 27);
            this.testNameLabel.Name = "testNameLabel";
            this.testNameLabel.Size = new System.Drawing.Size(141, 16);
            this.testNameLabel.TabIndex = 2;
            this.testNameLabel.Text = "부인과적 세포검사(공단)";
            this.testNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchResultPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.testNameLabel);
            this.Controls.Add(this.testCodeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchResultPanel";
            this.Size = new System.Drawing.Size(269, 46);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label testCodeLabel;
        private System.Windows.Forms.Label testNameLabel;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}