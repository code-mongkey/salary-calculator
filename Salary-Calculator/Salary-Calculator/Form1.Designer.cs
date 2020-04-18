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
            this.customCalendar1 = new exCalendar.CustomCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numStartHour = new System.Windows.Forms.NumericUpDown();
            this.numStartMin = new System.Windows.Forms.NumericUpDown();
            this.rbETC = new System.Windows.Forms.RadioButton();
            this.rbEvening = new System.Windows.Forms.RadioButton();
            this.rbMorning = new System.Windows.Forms.RadioButton();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numEndMin = new System.Windows.Forms.NumericUpDown();
            this.numEndHour = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpWorkDay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlEnd = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHour)).BeginInit();
            this.pnlEnd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customCalendar1
            // 
            this.customCalendar1.dutyFontSize = 0F;
            this.customCalendar1.Location = new System.Drawing.Point(12, 46);
            this.customCalendar1.MenuStrip = null;
            this.customCalendar1.Name = "customCalendar1";
            this.customCalendar1.schedulerFontSize = 0F;
            this.customCalendar1.SelectedDate = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.customCalendar1.Size = new System.Drawing.Size(600, 557);
            this.customCalendar1.TabIndex = 0;
            this.customCalendar1.UserGrade = ((long)(0));
            this.customCalendar1.UserName = null;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlEnd);
            this.panel1.Controls.Add(this.pnlStart);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dtpWorkDay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(618, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 269);
            this.panel1.TabIndex = 1;
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.label3);
            this.pnlStart.Controls.Add(this.label4);
            this.pnlStart.Controls.Add(this.label5);
            this.pnlStart.Controls.Add(this.numStartHour);
            this.pnlStart.Controls.Add(this.numStartMin);
            this.pnlStart.Location = new System.Drawing.Point(16, 109);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(314, 37);
            this.pnlStart.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "근무시작시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(186, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "시";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(274, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "분";
            // 
            // numStartHour
            // 
            this.numStartHour.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numStartHour.Location = new System.Drawing.Point(129, 5);
            this.numStartHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numStartHour.Name = "numStartHour";
            this.numStartHour.Size = new System.Drawing.Size(51, 29);
            this.numStartHour.TabIndex = 3;
            this.numStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStartHour.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // numStartMin
            // 
            this.numStartMin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numStartMin.Location = new System.Drawing.Point(217, 5);
            this.numStartMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numStartMin.Name = "numStartMin";
            this.numStartMin.Size = new System.Drawing.Size(51, 29);
            this.numStartMin.TabIndex = 3;
            this.numStartMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStartMin.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // rbETC
            // 
            this.rbETC.AutoSize = true;
            this.rbETC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbETC.Location = new System.Drawing.Point(10, 62);
            this.rbETC.Name = "rbETC";
            this.rbETC.Size = new System.Drawing.Size(60, 25);
            this.rbETC.TabIndex = 5;
            this.rbETC.Text = "기타";
            this.rbETC.UseVisualStyleBackColor = true;
            // 
            // rbEvening
            // 
            this.rbEvening.AutoSize = true;
            this.rbEvening.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbEvening.Location = new System.Drawing.Point(10, 33);
            this.rbEvening.Name = "rbEvening";
            this.rbEvening.Size = new System.Drawing.Size(92, 25);
            this.rbEvening.TabIndex = 5;
            this.rbEvening.Text = "오후근무";
            this.rbEvening.UseVisualStyleBackColor = true;
            // 
            // rbMorning
            // 
            this.rbMorning.AutoSize = true;
            this.rbMorning.Checked = true;
            this.rbMorning.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbMorning.Location = new System.Drawing.Point(10, 4);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(92, 25);
            this.rbMorning.TabIndex = 5;
            this.rbMorning.TabStop = true;
            this.rbMorning.Text = "오전근무";
            this.rbMorning.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(338, 220);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(106, 34);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "행삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "행추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // numEndMin
            // 
            this.numEndMin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numEndMin.Location = new System.Drawing.Point(217, 3);
            this.numEndMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numEndMin.Name = "numEndMin";
            this.numEndMin.Size = new System.Drawing.Size(51, 29);
            this.numEndMin.TabIndex = 3;
            this.numEndMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEndMin.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // numEndHour
            // 
            this.numEndHour.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numEndHour.Location = new System.Drawing.Point(129, 3);
            this.numEndHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numEndHour.Name = "numEndHour";
            this.numEndHour.Size = new System.Drawing.Size(51, 29);
            this.numEndHour.TabIndex = 3;
            this.numEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEndHour.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(274, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "분";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(186, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "시";
            // 
            // dtpWorkDay
            // 
            this.dtpWorkDay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpWorkDay.Location = new System.Drawing.Point(138, 50);
            this.dtpWorkDay.Name = "dtpWorkDay";
            this.dtpWorkDay.Size = new System.Drawing.Size(272, 29);
            this.dtpWorkDay.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "근무종료시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "근무일";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(138, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 29);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "홍길동";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(618, 321);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(452, 282);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "근무일";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "시작시간";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "종료시간";
            this.columnHeader3.Width = 157;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(894, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlEnd
            // 
            this.pnlEnd.Controls.Add(this.label6);
            this.pnlEnd.Controls.Add(this.label7);
            this.pnlEnd.Controls.Add(this.label8);
            this.pnlEnd.Controls.Add(this.numEndHour);
            this.pnlEnd.Controls.Add(this.numEndMin);
            this.pnlEnd.Location = new System.Drawing.Point(16, 163);
            this.pnlEnd.Name = "pnlEnd";
            this.pnlEnd.Size = new System.Drawing.Size(314, 37);
            this.pnlEnd.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbMorning);
            this.panel2.Controls.Add(this.rbEvening);
            this.panel2.Controls.Add(this.rbETC);
            this.panel2.Location = new System.Drawing.Point(336, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 91);
            this.panel2.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(712, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 615);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customCalendar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHour)).EndInit();
            this.pnlEnd.ResumeLayout(false);
            this.pnlEnd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private exCalendar.CustomCalendar customCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numStartHour;
        private System.Windows.Forms.NumericUpDown numStartMin;
        private System.Windows.Forms.RadioButton rbETC;
        private System.Windows.Forms.RadioButton rbEvening;
        private System.Windows.Forms.RadioButton rbMorning;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numEndMin;
        private System.Windows.Forms.NumericUpDown numEndHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpWorkDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlEnd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
    }
}

