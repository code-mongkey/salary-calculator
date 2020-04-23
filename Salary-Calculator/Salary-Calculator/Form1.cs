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
    public partial class Form1 : Form
    {
        private const int HOUR_PAY = 8350;
        private Database database;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboWorkType.SelectedIndex = 0;

            database = new Database();
            database.ConnectDB();
            database.OpenDB();
            database.ClosedDB();


            customCalendar1.MenuStrip = contextMenuStrip1;

            dtStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0, DateTimeKind.Local);
            dtEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0, DateTimeKind.Local);

            SelectData();
        }

        private void SelectData()
        {
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
                names[i] = dgv1.Rows[i].Cells[5].Value.ToString();
            }
            customCalendar1.SetSchedual(days, names, customCalendar1.SelectedDate);

            int total = dgv1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));
            label5.Text = total.ToString();
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

            double pay = workTime.TotalHours * HOUR_PAY;
            string work_type = cboWorkType.Text;

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
            if (cboWorkType.Text == "오전근무")
            {
                dtStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0, DateTimeKind.Local);
                dtEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0, DateTimeKind.Local);

                dtStart.Enabled = false;
                dtEnd.Enabled = false;
            }
            else if(cboWorkType.Text == "오후근무")
            {
                dtStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0, DateTimeKind.Local);
                dtEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, DateTimeKind.Local);

                dtStart.Enabled = false;
                dtEnd.Enabled = false;
            }
            else
            {
                dtStart.Enabled = true;
                dtEnd.Enabled = true;
            }

        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
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

        private void 근무추가ToolStripMenuItem_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                AddWorkTime();
        }

        private void 근무삭제ToolStripMenuItem_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DeleteWorkTime();
        }
    }
}
