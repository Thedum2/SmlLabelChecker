using System.ComponentModel;

namespace SmlLabelChecker
{
    partial class LabelInput
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelInput));
            this.NumberLabel = new System.Windows.Forms.Label();
            this.Previous = new System.Windows.Forms.Button();
            this.RemainNumber = new System.Windows.Forms.Label();
            this.StartNumber = new System.Windows.Forms.Label();
            this.EndNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_1 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.Button_4 = new System.Windows.Forms.Button();
            this.Button_3 = new System.Windows.Forms.Button();
            this.Button_6 = new System.Windows.Forms.Button();
            this.Button_5 = new System.Windows.Forms.Button();
            this.Button_7 = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Button_0 = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.moveTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NumberLabel
            // 
            this.NumberLabel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumberLabel.Location = new System.Drawing.Point(12, 9);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(261, 38);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "17101";
            this.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(12, 227);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(126, 26);
            this.Previous.TabIndex = 7;
            this.Previous.Text = "이전";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // RemainNumber
            // 
            this.RemainNumber.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RemainNumber.Location = new System.Drawing.Point(150, 309);
            this.RemainNumber.Name = "RemainNumber";
            this.RemainNumber.Size = new System.Drawing.Size(123, 20);
            this.RemainNumber.TabIndex = 8;
            this.RemainNumber.Text = "남은 라벨 수 : 99";
            this.RemainNumber.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // StartNumber
            // 
            this.StartNumber.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartNumber.ForeColor = System.Drawing.Color.Red;
            this.StartNumber.Location = new System.Drawing.Point(12, 291);
            this.StartNumber.Name = "StartNumber";
            this.StartNumber.Size = new System.Drawing.Size(113, 17);
            this.StartNumber.TabIndex = 9;
            this.StartNumber.Text = "시작 : 17101";
            this.StartNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndNumber
            // 
            this.EndNumber.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EndNumber.ForeColor = System.Drawing.Color.Blue;
            this.EndNumber.Location = new System.Drawing.Point(12, 313);
            this.EndNumber.Name = "EndNumber";
            this.EndNumber.Size = new System.Drawing.Size(113, 17);
            this.EndNumber.TabIndex = 10;
            this.EndNumber.Text = "종료 : 17101";
            this.EndNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "사용한 바코드 수";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_1
            // 
            this.Button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Button_1.Location = new System.Drawing.Point(144, 105);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(129, 24);
            this.Button_1.TabIndex = 12;
            this.Button_1.Text = "1개(1)";
            this.Button_1.UseVisualStyleBackColor = false;
            this.Button_1.Click += new System.EventHandler(this.Button_1_Click);
            // 
            // Button_2
            // 
            this.Button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button_2.Location = new System.Drawing.Point(12, 135);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(126, 24);
            this.Button_2.TabIndex = 13;
            this.Button_2.Text = "2개(2)";
            this.Button_2.UseVisualStyleBackColor = false;
            this.Button_2.Click += new System.EventHandler(this.Button_2_Click);
            // 
            // Button_4
            // 
            this.Button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Button_4.Location = new System.Drawing.Point(12, 165);
            this.Button_4.Name = "Button_4";
            this.Button_4.Size = new System.Drawing.Size(126, 24);
            this.Button_4.TabIndex = 15;
            this.Button_4.Text = "4개(4)";
            this.Button_4.UseVisualStyleBackColor = false;
            this.Button_4.Click += new System.EventHandler(this.Button_4_Click);
            // 
            // Button_3
            // 
            this.Button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Button_3.Location = new System.Drawing.Point(144, 135);
            this.Button_3.Name = "Button_3";
            this.Button_3.Size = new System.Drawing.Size(129, 24);
            this.Button_3.TabIndex = 14;
            this.Button_3.Text = "3개(3)";
            this.Button_3.UseVisualStyleBackColor = false;
            this.Button_3.Click += new System.EventHandler(this.Button_3_Click);
            // 
            // Button_6
            // 
            this.Button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_6.Location = new System.Drawing.Point(12, 197);
            this.Button_6.Name = "Button_6";
            this.Button_6.Size = new System.Drawing.Size(126, 24);
            this.Button_6.TabIndex = 17;
            this.Button_6.Text = "6개(6)";
            this.Button_6.UseVisualStyleBackColor = false;
            this.Button_6.Click += new System.EventHandler(this.Button_6_Click);
            // 
            // Button_5
            // 
            this.Button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_5.Location = new System.Drawing.Point(144, 165);
            this.Button_5.Name = "Button_5";
            this.Button_5.Size = new System.Drawing.Size(129, 24);
            this.Button_5.TabIndex = 16;
            this.Button_5.Text = "5개(5)";
            this.Button_5.UseVisualStyleBackColor = false;
            this.Button_5.Click += new System.EventHandler(this.Button_5_Click);
            // 
            // Button_7
            // 
            this.Button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Button_7.Location = new System.Drawing.Point(144, 195);
            this.Button_7.Name = "Button_7";
            this.Button_7.Size = new System.Drawing.Size(129, 24);
            this.Button_7.TabIndex = 18;
            this.Button_7.Text = "7개(7)";
            this.Button_7.UseVisualStyleBackColor = false;
            this.Button_7.Click += new System.EventHandler(this.Button_7_Click);
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Done.ForeColor = System.Drawing.Color.White;
            this.Done.Location = new System.Drawing.Point(12, 259);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(261, 26);
            this.Done.TabIndex = 20;
            this.Done.Text = "완료";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(144, 225);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(129, 26);
            this.Next.TabIndex = 21;
            this.Next.Text = "다음";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Button_0
            // 
            this.Button_0.BackColor = System.Drawing.Color.Silver;
            this.Button_0.Location = new System.Drawing.Point(12, 107);
            this.Button_0.Name = "Button_0";
            this.Button_0.Size = new System.Drawing.Size(126, 24);
            this.Button_0.TabIndex = 22;
            this.Button_0.Text = "0개(0)";
            this.Button_0.UseVisualStyleBackColor = false;
            this.Button_0.Click += new System.EventHandler(this.Button_0_Click);
            // 
            // moveButton
            // 
            this.moveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moveButton.FlatAppearance.BorderSize = 0;
            this.moveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveButton.ForeColor = System.Drawing.Color.Transparent;
            this.moveButton.Location = new System.Drawing.Point(224, 71);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(49, 22);
            this.moveButton.TabIndex = 24;
            this.moveButton.Text = "이동";
            this.moveButton.UseVisualStyleBackColor = false;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // moveTextbox
            // 
            this.moveTextbox.Location = new System.Drawing.Point(150, 71);
            this.moveTextbox.Name = "moveTextbox";
            this.moveTextbox.Size = new System.Drawing.Size(68, 21);
            this.moveTextbox.TabIndex = 23;
            // 
            // LabelInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(285, 343);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.moveTextbox);
            this.Controls.Add(this.Button_0);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Button_7);
            this.Controls.Add(this.Button_6);
            this.Controls.Add(this.Button_5);
            this.Controls.Add(this.Button_4);
            this.Controls.Add(this.Button_3);
            this.Controls.Add(this.Button_2);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndNumber);
            this.Controls.Add(this.StartNumber);
            this.Controls.Add(this.RemainNumber);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.NumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "LabelInput";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabelInput_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Button_0;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.TextBox moveTextbox;

        private System.Windows.Forms.Button Done;

        private System.Windows.Forms.Button Button_7;

        private System.Windows.Forms.Button Button_4;
        private System.Windows.Forms.Button Button_3;
        private System.Windows.Forms.Button Button_6;
        private System.Windows.Forms.Button Button_5;

        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Button Button_2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label EndNumber;

        private System.Windows.Forms.Label StartNumber;

        private System.Windows.Forms.Label RemainNumber;

        private System.Windows.Forms.Button Previous;

        private System.Windows.Forms.Label NumberLabel;

        #endregion
    }
}