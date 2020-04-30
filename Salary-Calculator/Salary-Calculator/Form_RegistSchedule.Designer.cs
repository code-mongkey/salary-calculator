namespace Salary_Calculator
{
    partial class Form_RegistSchedule
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPartTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMonthPay = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.col_USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_START_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_END_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WORKING_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DAILY_PAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WORK_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPreMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblTotalWorkTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHoliPay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.customCalendar1 = new exCalendar.CustomCalendar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboPartTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(686, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 179);
            this.panel1.TabIndex = 1;
            // 
            // cboPartTime
            // 
            this.cboPartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPartTime.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboPartTime.FormattingEnabled = true;
            this.cboPartTime.Items.AddRange(new object[] {
            "오전근무",
            "오후근무",
            "기타근무"});
            this.cboPartTime.Location = new System.Drawing.Point(119, 55);
            this.cboPartTime.Name = "cboPartTime";
            this.cboPartTime.Size = new System.Drawing.Size(155, 29);
            this.cboPartTime.TabIndex = 8;
            this.cboPartTime.SelectedIndexChanged += new System.EventHandler(this.cboWorkType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "근무타입";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(323, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "근무종료";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(323, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "근무시작";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(497, 107);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(106, 34);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "행삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(385, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "행추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtEnd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(416, 55);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(187, 29);
            this.dtEnd.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtStart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(416, 12);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(187, 29);
            this.dtStart.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(119, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 29);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "홍길동";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자";
            // 
            // lblMonthPay
            // 
            this.lblMonthPay.AutoSize = true;
            this.lblMonthPay.Location = new System.Drawing.Point(1007, 598);
            this.lblMonthPay.Name = "lblMonthPay";
            this.lblMonthPay.Size = new System.Drawing.Size(11, 12);
            this.lblMonthPay.TabIndex = 9;
            this.lblMonthPay.Text = "0";
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
            this.dgv1.Location = new System.Drawing.Point(686, 197);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(640, 351);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
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
            // btnPreMonth
            // 
            this.btnPreMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnPreMonth.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.btnPreMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPreMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPreMonth.Location = new System.Drawing.Point(12, 13);
            this.btnPreMonth.Name = "btnPreMonth";
            this.btnPreMonth.Size = new System.Drawing.Size(60, 56);
            this.btnPreMonth.TabIndex = 6;
            this.btnPreMonth.Text = "◀";
            this.btnPreMonth.UseVisualStyleBackColor = false;
            this.btnPreMonth.Click += new System.EventHandler(this.btnPreMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnNextMonth.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.btnNextMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNextMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNextMonth.Location = new System.Drawing.Point(620, 13);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(60, 56);
            this.btnNextMonth.TabIndex = 7;
            this.btnNextMonth.Text = "▶";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(988, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "근무시간*시급";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(1332, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(44, 34);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "설정";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lblTotalWorkTime
            // 
            this.lblTotalWorkTime.AutoSize = true;
            this.lblTotalWorkTime.Location = new System.Drawing.Point(815, 598);
            this.lblTotalWorkTime.Name = "lblTotalWorkTime";
            this.lblTotalWorkTime.Size = new System.Drawing.Size(11, 12);
            this.lblTotalWorkTime.TabIndex = 9;
            this.lblTotalWorkTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(795, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "근무시간";
            // 
            // lblHoliPay
            // 
            this.lblHoliPay.AutoSize = true;
            this.lblHoliPay.Location = new System.Drawing.Point(919, 598);
            this.lblHoliPay.Name = "lblHoliPay";
            this.lblHoliPay.Size = new System.Drawing.Size(11, 12);
            this.lblHoliPay.TabIndex = 9;
            this.lblHoliPay.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(899, 573);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "주휴수당";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(964, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1079, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "=";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Location = new System.Drawing.Point(1115, 598);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(11, 12);
            this.lblTotalPay.TabIndex = 9;
            this.lblTotalPay.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1096, 573);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "예상월급";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(1332, 52);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(44, 34);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "조회";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // customCalendar1
            // 
            this.customCalendar1.dutyFontSize = 0F;
            this.customCalendar1.Location = new System.Drawing.Point(12, 13);
            this.customCalendar1.MenuStrip = null;
            this.customCalendar1.Name = "customCalendar1";
            this.customCalendar1.schedulerFontSize = 0F;
            this.customCalendar1.SelectedDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.customCalendar1.Size = new System.Drawing.Size(668, 607);
            this.customCalendar1.TabIndex = 0;
            this.customCalendar1.UserGrade = ((long)(0));
            this.customCalendar1.UserName = null;
            this.customCalendar1._changedDate += new exCalendar.CustomCalendar.DateTimeEventHandler(this.customCalendar1__changedDate);
            // 
            // Form_RegistSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 632);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHoliPay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalWorkTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMonthPay);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnPreMonth);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customCalendar1);
            this.Name = "Form_RegistSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "조회";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private exCalendar.CustomCalendar customCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.ComboBox cboPartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_START_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_END_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WORKING_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DAILY_PAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WORK_TYPE;
        private System.Windows.Forms.Label lblMonthPay;
        private System.Windows.Forms.Button btnPreMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTotalWorkTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHoliPay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnList;
    }
}

