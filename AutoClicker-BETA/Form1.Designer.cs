namespace LSH_AutoClicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MouseRightcheckBox = new System.Windows.Forms.CheckBox();
            this.MouseLeftcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TickSelectButton = new System.Windows.Forms.Button();
            this.TickSelectTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DevButton = new System.Windows.Forms.Button();
            this.ExButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StopcomboBox = new System.Windows.Forms.ComboBox();
            this.StartcomboBox = new System.Windows.Forms.ComboBox();
            this.MousePcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PointLableY = new System.Windows.Forms.Label();
            this.PointLableX = new System.Windows.Forms.Label();
            this.CursorGetTimer = new System.Windows.Forms.Timer(this.components);
            this.ClickTick = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MouseRightcheckBox);
            this.groupBox1.Controls.Add(this.MouseLeftcheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "마우스 클릭";
            // 
            // MouseRightcheckBox
            // 
            this.MouseRightcheckBox.AutoSize = true;
            this.MouseRightcheckBox.Location = new System.Drawing.Point(6, 43);
            this.MouseRightcheckBox.Name = "MouseRightcheckBox";
            this.MouseRightcheckBox.Size = new System.Drawing.Size(103, 17);
            this.MouseRightcheckBox.TabIndex = 1;
            this.MouseRightcheckBox.Text = "우클릭이다ㅇㅇ";
            this.MouseRightcheckBox.UseVisualStyleBackColor = true;
            // 
            // MouseLeftcheckBox
            // 
            this.MouseLeftcheckBox.AutoSize = true;
            this.MouseLeftcheckBox.Location = new System.Drawing.Point(6, 20);
            this.MouseLeftcheckBox.Name = "MouseLeftcheckBox";
            this.MouseLeftcheckBox.Size = new System.Drawing.Size(103, 17);
            this.MouseLeftcheckBox.TabIndex = 0;
            this.MouseLeftcheckBox.Text = "좌클릭이다임마";
            this.MouseLeftcheckBox.UseVisualStyleBackColor = true;
            this.MouseLeftcheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TickSelectButton);
            this.groupBox2.Controls.Add(this.TickSelectTextBox);
            this.groupBox2.Location = new System.Drawing.Point(134, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "시간설정이다 어쩔(ms)";
            // 
            // TickSelectButton
            // 
            this.TickSelectButton.Location = new System.Drawing.Point(6, 42);
            this.TickSelectButton.Name = "TickSelectButton";
            this.TickSelectButton.Size = new System.Drawing.Size(130, 23);
            this.TickSelectButton.TabIndex = 1;
            this.TickSelectButton.Text = "어쩔 적용(100추천)";
            this.TickSelectButton.UseVisualStyleBackColor = true;
            this.TickSelectButton.Click += new System.EventHandler(this.TickSelectButton_Click);
            // 
            // TickSelectTextBox
            // 
            this.TickSelectTextBox.Location = new System.Drawing.Point(6, 19);
            this.TickSelectTextBox.Name = "TickSelectTextBox";
            this.TickSelectTextBox.Size = new System.Drawing.Size(130, 20);
            this.TickSelectTextBox.TabIndex = 0;
            this.TickSelectTextBox.Text = "1000";
            this.TickSelectTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TickSelectTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TickSelectTextBox_KeyPress);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.Red;
            this.InfoLabel.Location = new System.Drawing.Point(6, 16);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(251, 37);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "작동안하는중임 ㅇㅇ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InfoLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "대충 진행상황이라는 글자";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DevButton);
            this.groupBox4.Controls.Add(this.ExButton);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.MousePcheckBox);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 77);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "대충 설정이라는 글자라는 글자";
            // 
            // DevButton
            // 
            this.DevButton.Location = new System.Drawing.Point(174, 50);
            this.DevButton.Name = "DevButton";
            this.DevButton.Size = new System.Drawing.Size(83, 23);
            this.DevButton.TabIndex = 4;
            this.DevButton.Text = "개발자다";
            this.DevButton.UseVisualStyleBackColor = true;
            this.DevButton.Click += new System.EventHandler(this.DevButton_Click);
            // 
            // ExButton
            // 
            this.ExButton.Location = new System.Drawing.Point(174, 29);
            this.ExButton.Name = "ExButton";
            this.ExButton.Size = new System.Drawing.Size(83, 23);
            this.ExButton.TabIndex = 3;
            this.ExButton.Text = "설명서다";
            this.ExButton.UseVisualStyleBackColor = true;
            this.ExButton.Click += new System.EventHandler(this.ExButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.StopcomboBox);
            this.groupBox6.Controls.Add(this.StartcomboBox);
            this.groupBox6.Location = new System.Drawing.Point(72, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(96, 57);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "뜨거운 키";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "정지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "시작";
            // 
            // StopcomboBox
            // 
            this.StopcomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopcomboBox.FormattingEnabled = true;
            this.StopcomboBox.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.StopcomboBox.Location = new System.Drawing.Point(32, 33);
            this.StopcomboBox.Name = "StopcomboBox";
            this.StopcomboBox.Size = new System.Drawing.Size(58, 21);
            this.StopcomboBox.TabIndex = 1;
            this.StopcomboBox.SelectedIndexChanged += new System.EventHandler(this.StopcomboBox_SelectedIndexChanged);
            // 
            // StartcomboBox
            // 
            this.StartcomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartcomboBox.FormattingEnabled = true;
            this.StartcomboBox.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.StartcomboBox.Location = new System.Drawing.Point(32, 12);
            this.StartcomboBox.Name = "StartcomboBox";
            this.StartcomboBox.Size = new System.Drawing.Size(58, 21);
            this.StartcomboBox.TabIndex = 0;
            this.StartcomboBox.SelectedIndexChanged += new System.EventHandler(this.StartcomboBox_SelectedIndexChanged);
            // 
            // MousePcheckBox
            // 
            this.MousePcheckBox.AutoSize = true;
            this.MousePcheckBox.Location = new System.Drawing.Point(174, 14);
            this.MousePcheckBox.Name = "MousePcheckBox";
            this.MousePcheckBox.Size = new System.Drawing.Size(84, 17);
            this.MousePcheckBox.TabIndex = 1;
            this.MousePcheckBox.Text = "마우스 고정";
            this.MousePcheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.PointLableY);
            this.groupBox5.Controls.Add(this.PointLableX);
            this.groupBox5.Location = new System.Drawing.Point(6, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(60, 57);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "좌표임";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "짜빠게티";
            // 
            // PointLableY
            // 
            this.PointLableY.AutoSize = true;
            this.PointLableY.Location = new System.Drawing.Point(6, 26);
            this.PointLableY.Name = "PointLableY";
            this.PointLableY.Size = new System.Drawing.Size(26, 13);
            this.PointLableY.TabIndex = 1;
            this.PointLableY.Text = "Y: 0";
            // 
            // PointLableX
            // 
            this.PointLableX.AutoSize = true;
            this.PointLableX.Location = new System.Drawing.Point(6, 13);
            this.PointLableX.Name = "PointLableX";
            this.PointLableX.Size = new System.Drawing.Size(26, 13);
            this.PointLableX.TabIndex = 0;
            this.PointLableX.Text = "X: 0";
            // 
            // CursorGetTimer
            // 
            this.CursorGetTimer.Enabled = true;
            this.CursorGetTimer.Tick += new System.EventHandler(this.CursorGetTimer_Tick);
            // 
            // ClickTick
            // 
            this.ClickTick.Enabled = true;
            this.ClickTick.Interval = 1000;
            this.ClickTick.Tick += new System.EventHandler(this.ClickTick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 242);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(304, 281);
            this.MinimumSize = new System.Drawing.Size(304, 281);
            this.Name = "Form1";
            this.Text = "승희의 존나 간단한 오토클릭";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox MouseLeftcheckBox;
        private System.Windows.Forms.CheckBox MouseRightcheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TickSelectTextBox;
        private System.Windows.Forms.Button TickSelectButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer CursorGetTimer;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label PointLableY;
        private System.Windows.Forms.Label PointLableX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox MousePcheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StopcomboBox;
        private System.Windows.Forms.ComboBox StartcomboBox;
        private System.Windows.Forms.Timer ClickTick;
        private System.Windows.Forms.Button DevButton;
        private System.Windows.Forms.Button ExButton;
    }
}

