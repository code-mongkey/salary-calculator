using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator
{
    public partial class Form_RegistSchedule : Form
    {
        private Database database;
        private Utilities.INIFile mConfig = new Utilities.INIFile(Application.StartupPath + "\\Config.ini");

        public Form_RegistSchedule()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPartTime.SelectedIndex = 0;

            database = new Database();
            database.ConnectDB();

            int MorningStartHour = mConfig.GetInt32("Setting", "MorningStartHour", 6);
            int MorningStartMin = mConfig.GetInt32("Setting", "MorningStartMin", 0);
            int MorningEndHour = mConfig.GetInt32("Setting", "MorningEndHour", 6);
            int MorningEndMin = mConfig.GetInt32("Setting", "MorningEndMin", 0);
            
            dtStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MorningStartHour, MorningStartMin, 0, DateTimeKind.Local);
            dtEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, MorningEndHour, MorningEndMin, 0, DateTimeKind.Local);

            dgv1.Columns[4].DefaultCellStyle.Format = "n0";

            SelectData();

            SetCombo();

            SetContextMenu();
        }

        private void SelectData()
        {
            double hourPay = mConfig.GetInt32("Setting", "HourPay", 8590);

            string[] column = new string[3] { "USER_ID", "FROM_DATE", "TO_DATE" };
            string st = new DateTime(customCalendar1.SelectedDate.Year, customCalendar1.SelectedDate.Month, 1, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss");
            string end = new DateTime(customCalendar1.SelectedDate.Year, customCalendar1.SelectedDate.Month + 1, 1, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss");
            string[] data = new string[3] { txtName.Text, st, end };
            DataSet dataSet = database.GetProcedure("SALARY.SP_DAILY_PAY_SELECT", column, data);
            dgv1.DataSource = dataSet.Tables[0];

            int[] days = new int[dgv1.Rows.Count];
            string[] names = new string[dgv1.Rows.Count];
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                days[i] = Convert.ToInt32(dgv1.Rows[i].Cells[1].Value.ToString().Substring(8, 2));
                names[i] = dgv1.Rows[i].Cells[3].Value.ToString();
            }
            customCalendar1.SetSchedual(days, names, customCalendar1.SelectedDate);

            int totalWorkTime = dgv1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[3].Value));
            lblTotalWorkTime.Text = totalWorkTime.ToString("n0");

            int total = dgv1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));
            lblMonthPay.Text = total.ToString("n0");

            double holiPay = totalWorkTime / 40.0 * 8 * hourPay;
            lblHoliPay.Text = holiPay.ToString("n0");

            lblTotalPay.Text = (total + holiPay).ToString("n0");
        }

        private void customCalendar1__changedDate(DateTime dt)
        {
            dtStart.Value = customCalendar1.SelectedDate + new TimeSpan(dtStart.Value.Hour, dtStart.Value.Minute, dtStart.Value.Second);
            dtEnd.Value = customCalendar1.SelectedDate + new TimeSpan(dtEnd.Value.Hour, dtEnd.Value.Minute, dtEnd.Value.Second);

            dgv1.ClearSelection();
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                if(dtStart.Value.Year.ToString() == dgv1.Rows[i].Cells[1].Value.ToString().Substring(0,4))
                {
                    if(dtStart.Value.Month.ToString().PadLeft(2, '0') == dgv1.Rows[i].Cells[1].Value.ToString().Substring(5, 2))
                    {
                        if (dtStart.Value.Day.ToString().PadLeft(2,'0') == dgv1.Rows[i].Cells[1].Value.ToString().Substring(8, 2))
                        {
                            dgv1.Rows[i].Selected = true;
                            return;
                        }
                    }

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWorkTime();
        }

        private void AddWorkTime()
        {
            DateTime startTime = dtStart.Value;
            DateTime endTime = dtEnd.Value;

            if (endTime.Hour == 0) endTime = endTime.AddHours(24);

            TimeSpan workTime = endTime - startTime;

            if (workTime.TotalMilliseconds < 0)
            {
                MessageBox.Show("종료시간이 시작시간보다 빠를 수 없습니다");
                return;
            }

            if (workTime.TotalHours > 24)
            {
                MessageBox.Show("24시간이상 연속근무로 추가할 수 없습니다");
                return;
            }
            


            //string date = dtStart.Value.ToShortDateString();
            string sStartTime = dtStart.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string sEndTime = dtEnd.Value.ToString("yyyy-MM-dd HH:mm:ss");

            double pay = workTime.TotalHours * mConfig.GetInt32("Setting", "HourPay", 8590);
            string work_type = cboPartTime.Text;

            DataTable table = (DataTable)dgv1.DataSource;
            DataRow dr = table.NewRow();
            dr["USER_ID"] = txtName.Text;
            dr["START_TIME"] = sStartTime;
            dr["END_TIME"] = sEndTime;
            dr["WORKING_TIME"] = workTime.TotalHours.ToString();
            dr["DAILY_PAY"] = pay.ToString();
            dr["WORK_TYPE"] = work_type;
            table.Rows.Add(dr);

            string[] column = new string[7] { "USER_ID", "START_TIME", "END_TIME", "WORKING_TIME", "DAILY_PAY", "WORK_TYPE", "CREATE_USER" };
            string[] data = new string[7] { txtName.Text, sStartTime, sEndTime, workTime.TotalHours.ToString(), pay.ToString(), work_type, txtName.Text };

            database.SetProcedure("SALARY.SP_DAILY_PAY_INSERT", column, data);
            //customCalendar1.SetSchedual(new int[1] { dtStart.Value.Day }, new string[1] { work_type }, customCalendar1.SelectedDate);
            SelectData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteWorkTime();
        }

        private void DeleteWorkTime()
        {
            for (int i = dgv1.RowCount - 1; i >= 0; i--)
            {
                if (dgv1.Rows[i].Selected)
                {
                    string[] column = new string[3] { "USER_ID", "START_TIME", "END_TIME" };
                    string[] data = new string[3] { txtName.Text, dgv1.Rows[i].Cells[1].Value.ToString(), dgv1.Rows[i].Cells[2].Value.ToString() };
                    database.SetProcedure("SALARY.SP_DAILY_PAY_DELETE", column, data);
                    //dgv1.Rows.Remove(dgv1.Rows[i]);
                }
            }
            SelectData();
        }

        private void cboWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int curYear = customCalendar1.SelectedDate.Year;
            //int curMonth = customCalendar1.SelectedDate.Month;
            //int curDay = customCalendar1.SelectedDate.Day;

            //if (cboPartTime.Text == "오전근무")
            //{
            //    int MorningStartHour = mConfig.GetInt32("Setting", "MorningStartHour", 6);
            //    int MorningStartMin = mConfig.GetInt32("Setting", "MorningStartMin", 0);
            //    int MorningEndHour = mConfig.GetInt32("Setting", "MorningEndHour", 6);
            //    int MorningEndMin = mConfig.GetInt32("Setting", "MorningEndMin", 0);

            //    dtStart.Value = new DateTime(curYear, curMonth, curDay, MorningStartHour, MorningStartMin, 0, DateTimeKind.Local);
            //    dtEnd.Value = new DateTime(curYear, curMonth, curDay, MorningEndHour, MorningEndMin, 0, DateTimeKind.Local);

            //    dtStart.Enabled = false;
            //    dtEnd.Enabled = false;
            //}
            //else if(cboPartTime.Text == "오후근무")
            //{
            //    int EveningStartHour = mConfig.GetInt32("Setting", "EveningStartHour", 6);
            //    int EveningStartMin = mConfig.GetInt32("Setting", "EveningStartMin", 0);
            //    int EveningEndHour = mConfig.GetInt32("Setting", "EveningEndHour", 6);
            //    int EveningEndMin = mConfig.GetInt32("Setting", "EveningEndMin", 0);

            //    dtStart.Value = new DateTime(curYear, curMonth, curDay, EveningStartHour, EveningStartMin, 0, DateTimeKind.Local);
            //    dtEnd.Value = new DateTime(curYear, curMonth, curDay, EveningEndHour, EveningEndMin, 0, DateTimeKind.Local);

            //    dtStart.Enabled = false;
            //    dtEnd.Enabled = false;
            //}
            //else
            //{
            //    dtStart.Enabled = true;
            //    dtEnd.Enabled = true;
            //}

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int year = Convert.ToInt32((dgv1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(0, 4)));
            int month = Convert.ToInt32((dgv1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(5, 2)));
            int day = Convert.ToInt32((dgv1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(8, 2)));
            int hour = Convert.ToInt32((dgv1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(11, 2)));
            int min = Convert.ToInt32((dgv1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(14, 2)));
            int sec = Convert.ToInt32((dgv1.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(17, 2)));
            //customCalendar1.SelectedDate = new DateTime(year, month, day);
            //customCalendar1__changedDate(new DateTime(year, month, day));
            customCalendar1.SelectedDate = new DateTime(year, month, day, hour, min, sec);
            //SelectData();
        }

        private void btnPreMonth_Click(object sender, EventArgs e)
        {
            customCalendar1.goToPreMonth();
            SelectData();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            customCalendar1.goToNextMonth();
            SelectData();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            using (Form_Setting frm = new Form_Setting())
            {
                frm.ShowDialog();
                frm.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectData();
            SetCombo();
            SetContextMenu();
        }

        private void SetCombo()
        {
            cboPartTime.Text = "";
            cboPartTime.Items.Clear();
            Dictionary<string, string> PartTimeList = mConfig.GetSectionValues("PartTimeList");
            foreach (KeyValuePair<string, string> list in PartTimeList)
            {
                cboPartTime.Items.Add(list.Value);
            }
        }

        private void SetContextMenu()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem menuItem;

            Dictionary<string, string> PartTimeList = mConfig.GetSectionValues("PartTimeList");
            foreach (KeyValuePair<string, string> list in PartTimeList)
            {
                menuItem = new ToolStripMenuItem();
                menuItem.Text = list.Value + " 추가";
                menuItem.MouseDown += new MouseEventHandler(this.AddMenuItem_Click);
                menu.Items.Add(menuItem);
            }

            menuItem = new ToolStripMenuItem();
            menuItem.Text = "근무삭제";
            menuItem.MouseDown += new MouseEventHandler(this.DelMenuItem_Click);
            menu.Items.Add(menuItem);

            customCalendar1.MenuStrip = menu;
        }


        private void AddMenuItem_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string name = ((ToolStripMenuItem)(sender)).Text.Replace(" 추가", "");
                cboPartTime.Text = name;
                int stHour = mConfig.GetInt32(name, "START_HOUR", 0);
                int stMin = mConfig.GetInt32(name, "START_MIN", 0);

                int endHour = mConfig.GetInt32(name, "END_HOUR", 0);
                int endMin = mConfig.GetInt32(name, "END_MIN", 0);

                dtStart.Value = new DateTime(dtStart.Value.Year, dtStart.Value.Month, dtStart.Value.Day, stHour, stMin, 0, DateTimeKind.Local);
                dtEnd.Value = new DateTime(dtEnd.Value.Year, dtEnd.Value.Month, dtEnd.Value.Day, endHour, endMin, 0, DateTimeKind.Local);

                AddWorkTime();
            }
        }

        private void DelMenuItem_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DeleteWorkTime();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            using (Form_ScheduleList frm = new Form_ScheduleList())
            {
                frm.ShowDialog();
                frm.Close();
            }
        }
    }
}
