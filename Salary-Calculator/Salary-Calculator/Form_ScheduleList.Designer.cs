namespace Salary_Calculator
{
    partial class Form_ScheduleList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.col_USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_START_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_END_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WORKING_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DAILY_PAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WORK_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_USER_ID,
            this.col_START_TIME,
            this.col_END_TIME,
            this.col_WORKING_TIME,
            this.col_DAILY_PAY,
            this.col_WORK_TYPE});
            this.dgv1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv1.Location = new System.Drawing.Point(12, 177);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1028, 387);
            this.dgv1.TabIndex = 6;
            // 
            // col_USER_ID
            // 
            this.col_USER_ID.DataPropertyName = "USER_ID";
            this.col_USER_ID.Frozen = true;
            this.col_USER_ID.HeaderText = "이름";
            this.col_USER_ID.Name = "col_USER_ID";
            this.col_USER_ID.ReadOnly = true;
            this.col_USER_ID.Width = 70;
            // 
            // col_START_TIME
            // 
            this.col_START_TIME.DataPropertyName = "START_TIME";
            dataGridViewCellStyle1.NullValue = null;
            this.col_START_TIME.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_START_TIME.Frozen = true;
            this.col_START_TIME.HeaderText = "시작시간";
            this.col_START_TIME.Name = "col_START_TIME";
            this.col_START_TIME.ReadOnly = true;
            this.col_START_TIME.Width = 120;
            // 
            // col_END_TIME
            // 
            this.col_END_TIME.DataPropertyName = "END_TIME";
            this.col_END_TIME.Frozen = true;
            this.col_END_TIME.HeaderText = "종료시간";
            this.col_END_TIME.Name = "col_END_TIME";
            this.col_END_TIME.ReadOnly = true;
            this.col_END_TIME.Width = 120;
            // 
            // col_WORKING_TIME
            // 
            this.col_WORKING_TIME.DataPropertyName = "WORKING_TIME";
            this.col_WORKING_TIME.Frozen = true;
            this.col_WORKING_TIME.HeaderText = "근무시간";
            this.col_WORKING_TIME.Name = "col_WORKING_TIME";
            this.col_WORKING_TIME.ReadOnly = true;
            // 
            // col_DAILY_PAY
            // 
            this.col_DAILY_PAY.DataPropertyName = "DAILY_PAY";
            this.col_DAILY_PAY.Frozen = true;
            this.col_DAILY_PAY.HeaderText = "일급";
            this.col_DAILY_PAY.Name = "col_DAILY_PAY";
            this.col_DAILY_PAY.ReadOnly = true;
            this.col_DAILY_PAY.Width = 80;
            // 
            // col_WORK_TYPE
            // 
            this.col_WORK_TYPE.DataPropertyName = "WORK_TYPE";
            this.col_WORK_TYPE.HeaderText = "파트타임";
            this.col_WORK_TYPE.Name = "col_WORK_TYPE";
            this.col_WORK_TYPE.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(382, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "근무시작";
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "yyyy-MM";
            this.dt1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(475, 36);
            this.dt1.Name = "dt1";
            this.dt1.ShowUpDown = true;
            this.dt1.Size = new System.Drawing.Size(187, 29);
            this.dt1.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(178, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 29);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "홍길동";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "사용자";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(176, 102);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(11, 12);
            this.lblPay.TabIndex = 12;
            this.lblPay.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(73, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "현재월급";
            // 
            // Form_ScheduleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 576);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Name = "Form_ScheduleList";
            this.Text = "Form_ScheduleList";
            this.Load += new System.EventHandler(this.Form_ScheduleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_START_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_END_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WORKING_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DAILY_PAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WORK_TYPE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label label4;
    }
}