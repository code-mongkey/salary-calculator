namespace Salary_Calculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboWorkType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.customCalendar1 = new exCalendar.CustomCalendar();
            this.col_USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_START_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_END_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WORKING_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DAILY_PAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WORK_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboWorkType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDel);
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
            // cboWorkType
            // 
            this.cboWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWorkType.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboWorkType.FormattingEnabled = true;
            this.cboWorkType.Items.AddRange(new object[] {
            "오전근무",
            "오후근무",
            "기타근무"});
            this.cboWorkType.Location = new System.Drawing.Point(119, 55);
            this.cboWorkType.Name = "cboWorkType";
            this.cboWorkType.Size = new System.Drawing.Size(155, 29);
            this.cboWorkType.TabIndex = 8;
            this.cboWorkType.SelectedIndexChanged += new System.EventHandler(this.cboWorkType_SelectedIndexChanged);
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
            this.dtEnd.Enabled = false;
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
            this.dtStart.Enabled = false;
            this.dtStart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(416, 12);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(187, 29);
            this.dtStart.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
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
            this.dgv1.Size = new System.Drawing.Size(640, 423);
            this.dgv1.TabIndex = 5;
            // 
            // customCalendar1
            // 
            this.customCalendar1.dutyFontSize = 0F;
            this.customCalendar1.Location = new System.Drawing.Point(12, 13);
            this.customCalendar1.Name = "customCalendar1";
            this.customCalendar1.schedulerFontSize = 0F;
            this.customCalendar1.SelectedDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.customCalendar1.Size = new System.Drawing.Size(668, 607);
            this.customCalendar1.TabIndex = 0;
            this.customCalendar1.UserGrade = ((long)(0));
            this.customCalendar1.UserName = null;
            this.customCalendar1._changedDate += new exCalendar.CustomCalendar.DateTimeEventHandler(this.customCalendar1__changedDate);
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
            dataGridViewCellStyle6.NullValue = null;
            this.col_START_TIME.DefaultCellStyle = dataGridViewCellStyle6;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 632);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customCalendar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cboWorkType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_START_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_END_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WORKING_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DAILY_PAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WORK_TYPE;
        private System.Windows.Forms.Label label5;
    }
}

