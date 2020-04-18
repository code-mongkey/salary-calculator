namespace exCalendar
{
    partial class CustomCalendar
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomCalendar));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_caption = new System.Windows.Forms.Label();
            this.btnPreviosMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.panel_day = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_caption);
            this.splitContainer1.Panel1.Controls.Add(this.btnPreviosMonth);
            this.splitContainer1.Panel1.Controls.Add(this.btnNextMonth);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_day);
            // 
            // label_caption
            // 
            this.label_caption.BackColor = System.Drawing.Color.White;
            this.label_caption.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.label_caption, "label_caption");
            this.label_caption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_caption.Name = "label_caption";
            this.label_caption.Click += new System.EventHandler(this.label_caption_Click);
            // 
            // btnPreviosMonth
            // 
            this.btnPreviosMonth.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnPreviosMonth, "btnPreviosMonth");
            this.btnPreviosMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPreviosMonth.Name = "btnPreviosMonth";
            this.btnPreviosMonth.UseVisualStyleBackColor = false;
            this.btnPreviosMonth.Click += new System.EventHandler(this.btnPreviosMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnNextMonth, "btnNextMonth");
            this.btnNextMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // panel_day
            // 
            this.panel_day.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel_day, "panel_day");
            this.panel_day.Name = "panel_day";
            // 
            // CustomCalendar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CustomCalendar";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer  splitContainer1;
        private System.Windows.Forms.Label label_caption;
        private System.Windows.Forms.Panel panel_day;
        private System.Windows.Forms.Button btnPreviosMonth;
        private System.Windows.Forms.Button btnNextMonth;
    }
}
