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
    public partial class Form_ScheduleList : Form
    {
        Database database = new Database();

        public Form_ScheduleList()
        {
            InitializeComponent();
        }

        private void Form_ScheduleList_Load(object sender, EventArgs e)
        {
            dgv1.Columns[4].DefaultCellStyle.Format = "n0";
            database.ConnectDB();
        }


        private void SelectData()
        {
            string[] column = new string[3] { "USER_ID", "FROM_DATE", "TO_DATE" };
            string st = new DateTime(dt1.Value.Year, dt1.Value.Month, 1, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss");
            string end = new DateTime(dt1.Value.Year, dt1.Value.Month + 1, 1, 0, 0, 0).ToString("yyyy-MM-dd HH:mm:ss");
            string[] data = new string[3] { txtName.Text, st, end };
            DataSet dataSet = database.GetProcedure("SALARY.SP_DAILY_PAY_SELECT", column, data);
            dgv1.DataSource = dataSet.Tables[0];

            //int[] days = new int[dgv1.Rows.Count];
            //string[] names = new string[dgv1.Rows.Count];
            //for (int i = 0; i < dgv1.Rows.Count; i++)
            //{
            //    days[i] = Convert.ToInt32(dgv1.Rows[i].Cells[1].Value.ToString().Substring(8, 2));
            //    names[i] = dgv1.Rows[i].Cells[5].Value.ToString();
            //}
            //customCalendar1.SetSchedual(days, names, customCalendar1.SelectedDate);

            //int total = dgv1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));
            //lblMonthPay.Text = total.ToString("n0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectData();

            int total = dgv1.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[4].Value));
            lblPay.Text = total.ToString("n0");
        }
    }
}
