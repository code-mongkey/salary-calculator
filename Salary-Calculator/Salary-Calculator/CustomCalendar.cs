//소스출처: http://blog.naver.com/PostView.nhn?blogId=becoming23&logNo=221255811325&parentCategoryNo=9&categoryNo=&viewDate=&isShowPopularPosts=true&from=search

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exCalendar
{
    public partial class CustomCalendar : UserControl
    {
        public ContextMenuStrip MenuStrip
        {
            get
            {
                return likeCal.MenuStrip;
            }
            set
            {
                likeCal.MenuStrip = value;
            }
        }

        public string UserName
        {
            get
            {
                return likeCal.UserName;
            }
            set
            {
                likeCal.UserName = value;
            }
        }

        public Int64 UserGrade
        {
            get
            {
                return likeCal.UserGrade;
            }
            set
            {
                likeCal.UserGrade = value;
            }
        }

        public float dutyFontSize
        {
            get
            {
                return likeCal.dutyFontSize;
            }
            set
            {
                likeCal.dutyFontSize = value;
            }
        }

        public float schedulerFontSize
        {
            get
            {
                return likeCal.schedulerFontSize;
            }
            set
            {
                likeCal.schedulerFontSize = value;
            }
        }

        public delegate void DateTimeEventHandler(DateTime dt);
        public event DateTimeEventHandler _changedDate;
        LikeCal likeCal = new LikeCal();
        public CustomCalendar()
        {
            InitializeComponent();
            likeCal._changeDate += new LikeCal.dtDelegate(LikeCal__changeDate);
            likeCal.Dock = DockStyle.Fill;
            likeCal.SelectDate(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));

            label_caption.Font = new System.Drawing.Font("맑은 고딕", 22, FontStyle.Bold);
            label_caption.Text = DateTime.Now.Year + "년 " + DateTime.Now.Month + "월";

            panel_day.Controls.Add(likeCal);

            panel_day.BackColor = Color.FromArgb(41, 128, 185);
        }

        public DateTime SelectedDate
        {
            set 
            {
                likeCal.dtValue = value;
            }
            get
            {
                return likeCal.dtValue;
            }
        }

        private void LikeCal__changeDate(DateTime dt)
        {
            label_caption.Text = dt.Year + "년 " + dt.Month + "월";
            if(_changedDate != null) _changedDate(likeCal.dtValue);
        }
        
        private void label_next_Click(object sender, EventArgs e)
        {
            likeCal.nextMonth();
        }

        private void label_pre_Click(object sender, EventArgs e)
        {
            likeCal.preMonth();
        }

        private void label_caption_Click(object sender, EventArgs e)
        {
            likeCal.moveToToday();
        }

        public void SetHoliday(int[] onlyDayDisit, string[] redDayName, DateTime dt)
        {
            likeCal.SetRedDay(onlyDayDisit, redDayName);
            likeCal.SelectDate(dt);
            label_caption.Text = dt.Year + "년 " + dt.Month + "월";
        }

        public void SetSchedual(int[] onlyDayDisit, string[] redDayName, DateTime dt)
        {
            likeCal.SetScheduleDay(onlyDayDisit, redDayName);
            likeCal.ScheduleDate(dt);
        }

        public void SetDuty(int[] onlyDayDisit, string[] redDayName, DateTime dt)
        {
            likeCal.SetDutyDay(onlyDayDisit, redDayName);
            likeCal.DutyDate(dt);
        }

        public void goToToday()
        {
            likeCal.moveToToday();
        }
        public void goToPreDay()
        {
            likeCal.preDay();
        }
        public void goToNextDay()
        {
            likeCal.nextDay();
        }
        public void goToPreWeek()
        {
            likeCal.preWeek();
        }
        public void goToNextWeek()
        {
            likeCal.nextWeek();
        }
        public void goToPreMonth()
        {
            likeCal.preMonth();
        }
        public void goToNextMonth()
        {
            likeCal.nextMonth();
        }

        private void SetLabelCaption(DateTime dt)
        {
            label_caption.Text = dt.Year + "년 " + dt.Month + "월";
        }

    }

    class dLabel : Label
    {
        public dLabel()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }
    }

    class LikeCal : TableLayoutPanel
    {
        public ContextMenuStrip MenuStrip { get; set; }
        public delegate void dtDelegate(DateTime dt);
        public event dtDelegate _changeDate;

        public string UserName { get; set; }
        public Int64 UserGrade { get; set; }
        public float dutyFontSize { get; set; }
        public float schedulerFontSize { get; set; }

        int Month = DateTime.Now.Month;
        public DateTime dtValue = DateTime.Now;
        public dLabel[] TB = new dLabel[42];
        public dLabel[] TB2 = new dLabel[42];
        int[] redDayList = null;
        string[] redDayName = null;
        int[] ScheduleDayList = null;
        string[] ScheduleDayName = null;
        int[] DutyDayList = null;
        string[] DutyDayName = null;

        public LikeCal()
        {
            DoubleBuffered = true;
            setRowColumns(7, 7);
        }

        public void SetRedDay(int[] redDayList, string[] redDayName)
        {
            this.redDayList = redDayList;
            this.redDayName = redDayName;
        }

        public void SetScheduleDay(int[] ScheduleDayList, string[] ScheduleDayName)
        {
            this.ScheduleDayList = ScheduleDayList;
            this.ScheduleDayName = ScheduleDayName;
        }

        public void SetDutyDay(int[] DutyDayList, string[] DutyDayName)
        {
            this.DutyDayList = DutyDayList;
            this.DutyDayName = DutyDayName;
        }

        private void likeCal_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Control)sender).Text != null && ((Control)sender).Text != "")
            {
                DateTime dt;
                try
                {
                    dt = new DateTime(dtValue.Year, dtValue.Month, int.Parse(((Control)sender).Text.Split('\n')[0]), 0, 0, 0);
                }
                catch 
                {
                    return;
                }
                //_changeDate = SelectDate;
                SelectDate(dt);
                ScheduleDate(dt);
                if (UserName != null)
                    DutyDate(dt);
                if (_changeDate != null) _changeDate(dt);
            }
        }

        //달력 그리기
        public void setRowColumns(int rows, int columns)
        {
            ColumnCount = columns;
            RowCount = rows;
            for (int i = 0; i < RowCount; i++)
            {
                if( i == 0)
                    RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                else
                    RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
                

            for (int i = 0; i < ColumnCount; i++) 
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            //int cnt = 0;
            dLabel tb = null;
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    tb = new dLabel();
                    tb.AutoSize = false;
                    if (i == 0)             //첫 줄은 요일이다.
                    {
                        tb.Text = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.AbbreviatedDayNames[j][0].ToString() + "요일";
                        //토요일 일요일 타이틀 색 변경
                        if (j == 0 || j == 6)
                            tb.ForeColor = System.Drawing.Color.FromArgb(255, 250, 54, 156);
                        else
                            tb.ForeColor = System.Drawing.Color.White;

                        tb.BackColor = System.Drawing.Color.FromArgb(255, 148, 214, 240);
                        
                        tb.TextAlign = ContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        tb.ForeColor = System.Drawing.Color.Black;
                        tb.BackColor = System.Drawing.Color.FromArgb(255, 246, 229);
                        tb.MouseClick += new MouseEventHandler(likeCal_MouseClick);
                        tb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                        tb.MouseHover += new EventHandler(dLabel_MouseOver);
                        TB[j + ((i-1) * 7)] = tb;    
                    }

                    tb.Font = new System.Drawing.Font("나눔바른고딕", 14, FontStyle.Bold );
                    //tb.BorderStyle = BorderStyle.None;
                    tb.Margin = new Padding(1);
                    tb.Padding = new Padding(0);
                    tb.Dock = DockStyle.Fill;
                    this.BackColor = Color.FromArgb(255, 230, 234, 243);
                    Controls.Add(tb, j, i);
                }
            }
        }

        private void dLabel_MouseOver(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(((Control)sender), ((Control)sender).Text);            
        }
                
        public void SelectDate(DateTime DT)
        {
            dtValue = DT;

            ClearDay();

            DateTime Start = new DateTime(DT.Year, DT.Month, 1);
            int End = DateTime.DaysInMonth(DT.Year, DT.Month);
            int week = (int)Start.DayOfWeek;

            for (int var = 1; var <= End; var++)
            {   
                int index = var + week -1;

                TB[index].Cursor = Cursors.Hand;
                TB[index].Text = string.Format("{0:0}", var);
                TB[index].BackColor = Color.White;

                TB[index].Tag = Start.AddDays(var - 1);
                
                int index1 = 0;

                if (redDayList != null && (index1 = Array.IndexOf(redDayList, var)) >= 0)
                {
                    TB[index].ForeColor = System.Drawing.Color.FromArgb(255, 250, 54,156);//선택된 날짜가 리스트에 있을 경우

                    if (redDayName[index1] != null)
                        TB[index].Text += "\n" + redDayName[index1];
                }
                else
                {
                    TB[index].ForeColor = System.Drawing.Color.FromArgb(255, 2, 109, 191);

                    if (dtValue.Year == DateTime.Now.Year && dtValue.Month == DateTime.Now.Month && TB[index].Text == DateTime.Now.Day.ToString())
                    {
                        //TB[index].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        TB[index].BackColor = System.Drawing.Color.FromArgb(255, 230, 240, 255);

                    }

                    if (dtValue.Day.ToString() == TB[index].Text)
                    {
                        TB[index].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    }   
                }
            }

            foreach (var item in TB)
            {
                if (item.Text != "")
                    item.ContextMenuStrip = MenuStrip;
                else
                {
                    item.ContextMenuStrip = null;
                    item.Tag = null;
                }
            }
        }

        public void ScheduleDate(DateTime DT)
        {
            dtValue = DT;
            
            DateTime Start = new DateTime(DT.Year, DT.Month, 1);
            int End = DateTime.DaysInMonth(DT.Year, DT.Month);
            int week = (int)Start.DayOfWeek;

            for (int var = 1; var <= End; var++)
            {
                int index = var + week - 1;

                if (schedulerFontSize == 0)
                    schedulerFontSize = 14;

                TB[index].Font = new System.Drawing.Font("나눔바른고딕", schedulerFontSize, FontStyle.Bold);
                TB[index].Cursor = Cursors.Hand;
                TB[index].Text = string.Format("{0:0}", var);
                TB[index].BackColor = Color.White;

                TB[index].Tag = Start.AddDays(var - 1);

                int index1 = 0;

                if (redDayList != null && (index1 = Array.IndexOf(redDayList, var)) >= 0)
                {
                    if (redDayName[index1] != null)
                        TB[index].Text += "\n" + redDayName[index1];
                }

                if (ScheduleDayList != null && (index1 = Array.IndexOf(ScheduleDayList, var)) >= 0)
                {
                    if (ScheduleDayName[index1] != null)
                    {
                        TB[index].Text += "\n" + ScheduleDayName[index1];
                        TB[index].BackColor = System.Drawing.Color.FromArgb(255, 255, 230, 200);
                    }
                }
            }

            foreach (var item in TB)
            {
                if (item.Text != "")
                    item.ContextMenuStrip = MenuStrip;
                else
                {
                    item.ContextMenuStrip = null;
                    item.Tag = null;
                }
            }
        }

        public void DutyDate(DateTime DT)
        {
            dtValue = DT;

            DateTime Start = new DateTime(DT.Year, DT.Month, 1);
            int End = DateTime.DaysInMonth(DT.Year, DT.Month);
            int week = (int)Start.DayOfWeek;

            for (int var = 1; var <= End; var++)
            {
                int index = var + week - 1;

                if (dutyFontSize == 0)
                    dutyFontSize = 14;

                TB[index].Font = new System.Drawing.Font("나눔바른고딕", dutyFontSize, FontStyle.Bold);

                TB[index].Cursor = Cursors.Hand;
                TB[index].Text = string.Format("{0:0}", var);
                TB[index].BackColor = Color.White;

                TB[index].Tag = Start.AddDays(var - 1);

                int index1 = 0;

                if (DutyDayList != null && (index1 = Array.IndexOf(DutyDayList, var)) >= 0)
                {
                    if (DutyDayName[index1] != null)
                        TB[index].Text += "\n" + DutyDayName[index1];
                }
            }

            foreach (var item in TB)
            {
                if (item.Text != "")
                {
                    //본인과 특정 권한자만 메뉴 입력 하기
                    //if (item.Text.Contains(UserName))
                    //    item.ContextMenuStrip = MenuStrip;
                    //else
                    //    if (UserGrade > 2)
                    //    item.ContextMenuStrip = null;
                    //else
                    //    item.ContextMenuStrip = MenuStrip;

                    item.ContextMenuStrip = MenuStrip;
                }
                else
                {
                    item.ContextMenuStrip = null;
                    item.Tag = null;
                }
            }
        }

        public void nextMonth()
        {
            DateTime dt = dtValue.AddMonths(1);
            SelectDate(dt);
            if (_changeDate != null) _changeDate(dt);
        }
        public void preMonth()
        {
            DateTime dt = dtValue.AddMonths(-1);
            SelectDate(dt);
            if (_changeDate != null) _changeDate(dt);
        }
        public void nextWeek()
        {
            DateTime dt = dtValue.AddDays(7);
            SelectDate(dt);
            if (_changeDate != null) _changeDate(dt);
        }
        public void preWeek()
        {
            DateTime dt = dtValue.AddDays(-7);
            SelectDate(dt);
            if (_changeDate != null) _changeDate(dt);
        }
        public void nextDay()
        {
            DateTime dt = dtValue.AddDays(1);
            SelectDate(dt);
            if (_changeDate != null) _changeDate(dt);
        }
        public void preDay()
        {
            DateTime dt = dtValue.AddDays(-1);
            SelectDate(dt);
            if (_changeDate != null) _changeDate(dt);
        }
        public void moveToToday()
        {
            //DateTime dt = DateTime.Now;
            //SelectDate(dt);
            //if (_changeDate != null) _changeDate(dt);
        }

        public void ClearDay()
        {
            for(int i = 0; i < 42; i++)
            {
                TB[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                
                TB[i].BackColor = Color.White;   //날짜 없는 날 색 변경
                TB[i].Cursor = Cursors.Default;
                TB[i].Text = string.Empty;
            }
        }
    }
}
