namespace Salary_Calculator
{
    partial class Form_Setting
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtInternHourPay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHourPay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNightTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtNightTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboPartTime = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddPartTime = new System.Windows.Forms.Button();
            this.btnDelPartTime = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(43, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "야간근무 적용시간";
            // 
            // txtInternHourPay
            // 
            this.txtInternHourPay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInternHourPay.Location = new System.Drawing.Point(216, 64);
            this.txtInternHourPay.Name = "txtInternHourPay";
            this.txtInternHourPay.Size = new System.Drawing.Size(181, 29);
            this.txtInternHourPay.TabIndex = 1;
            this.txtInternHourPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(43, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "수습시급";
            // 
            // txtHourPay
            // 
            this.txtHourPay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtHourPay.Location = new System.Drawing.Point(216, 18);
            this.txtHourPay.Name = "txtHourPay";
            this.txtHourPay.Size = new System.Drawing.Size(181, 29);
            this.txtHourPay.TabIndex = 0;
            this.txtHourPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "기본시급";
            // 
            // dtNightTimeEnd
            // 
            this.dtNightTimeEnd.CustomFormat = "HH:mm";
            this.dtNightTimeEnd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtNightTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNightTimeEnd.Location = new System.Drawing.Point(326, 113);
            this.dtNightTimeEnd.Name = "dtNightTimeEnd";
            this.dtNightTimeEnd.ShowUpDown = true;
            this.dtNightTimeEnd.Size = new System.Drawing.Size(71, 29);
            this.dtNightTimeEnd.TabIndex = 3;
            // 
            // dtNightTimeStart
            // 
            this.dtNightTimeStart.CustomFormat = "HH:mm";
            this.dtNightTimeStart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtNightTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNightTimeStart.Location = new System.Drawing.Point(216, 113);
            this.dtNightTimeStart.Name = "dtNightTimeStart";
            this.dtNightTimeStart.ShowUpDown = true;
            this.dtNightTimeStart.Size = new System.Drawing.Size(73, 29);
            this.dtNightTimeStart.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "HH:mm";
            this.dtStart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(146, 114);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(73, 29);
            this.dtStart.TabIndex = 4;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "HH:mm";
            this.dtEnd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(256, 114);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(71, 29);
            this.dtEnd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(296, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "~";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(226, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "~";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(257, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboPartTime
            // 
            this.cboPartTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboPartTime.FormattingEnabled = true;
            this.cboPartTime.Location = new System.Drawing.Point(146, 60);
            this.cboPartTime.Name = "cboPartTime";
            this.cboPartTime.Size = new System.Drawing.Size(181, 29);
            this.cboPartTime.TabIndex = 10;
            this.cboPartTime.SelectedIndexChanged += new System.EventHandler(this.cboPartTime_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboPartTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnDelPartTime);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.btnAddPartTime);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(449, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 229);
            this.panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(12, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "근무 시간 설정";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtHourPay);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtInternHourPay);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtNightTimeEnd);
            this.panel2.Controls.Add(this.dtNightTimeStart);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 229);
            this.panel2.TabIndex = 11;
            // 
            // btnAddPartTime
            // 
            this.btnAddPartTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddPartTime.Location = new System.Drawing.Point(52, 166);
            this.btnAddPartTime.Name = "btnAddPartTime";
            this.btnAddPartTime.Size = new System.Drawing.Size(140, 41);
            this.btnAddPartTime.TabIndex = 8;
            this.btnAddPartTime.Text = "추가";
            this.btnAddPartTime.UseVisualStyleBackColor = true;
            this.btnAddPartTime.Click += new System.EventHandler(this.btnAddPartTime_Click);
            // 
            // btnDelPartTime
            // 
            this.btnDelPartTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelPartTime.Location = new System.Drawing.Point(198, 166);
            this.btnDelPartTime.Name = "btnDelPartTime";
            this.btnDelPartTime.Size = new System.Drawing.Size(140, 41);
            this.btnDelPartTime.TabIndex = 9;
            this.btnDelPartTime.Text = "삭제";
            this.btnDelPartTime.UseVisualStyleBackColor = true;
            this.btnDelPartTime.Click += new System.EventHandler(this.btnDelPartTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "근무 이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "근무 시간";
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 258);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Setting";
            this.Text = "Form_Setting";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInternHourPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHourPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNightTimeEnd;
        private System.Windows.Forms.DateTimePicker dtNightTimeStart;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboPartTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelPartTime;
        private System.Windows.Forms.Button btnAddPartTime;
        private System.Windows.Forms.Panel panel2;
    }
}