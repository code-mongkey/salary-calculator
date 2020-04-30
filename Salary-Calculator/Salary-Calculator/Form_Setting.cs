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
    public partial class Form_Setting : Form
    {
        Utilities.INIFile mConfig = new Utilities.INIFile(Application.StartupPath + "\\Config.ini");

        public Form_Setting()
        {
            InitializeComponent();
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            string hourPay = mConfig.GetString("Setting", "HourPay", "8590");
            string internHourPay = mConfig.GetString("Setting", "InternHourPay", "7650");

            int NightTimeStartHour = mConfig.GetInt32("Setting", "NightTimeStartHour", 22);
            int NightTimeStartMin = mConfig.GetInt32("Setting", "NightTimeStartMin", 0);

            int NightTimeEndHour = mConfig.GetInt32("Setting", "NightTimeEndHour", 6);
            int NightTimeEndMin = mConfig.GetInt32("Setting", "NightTimeEndMin", 0);

            txtHourPay.Text = hourPay;
            txtInternHourPay.Text = internHourPay;

            dtNightTimeStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, NightTimeStartHour, NightTimeStartMin, 0, DateTimeKind.Local);
            dtNightTimeEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, NightTimeEndHour, NightTimeEndMin, 0, DateTimeKind.Local);

            LoadCombo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mConfig.WriteValue("Setting", "HourPay", txtHourPay.Text);
            mConfig.WriteValue("Setting", "InternHourPay", txtInternHourPay.Text);

            mConfig.WriteValue("Setting", "NightTimeStartHour", dtNightTimeStart.Value.Hour);
            mConfig.WriteValue("Setting", "NightTimeStartMin", dtNightTimeStart.Value.Minute);
            mConfig.WriteValue("Setting", "NightTimeEndHour", dtNightTimeEnd.Value.Hour);
            mConfig.WriteValue("Setting", "NightTimeEndMin", dtNightTimeEnd.Value.Minute);
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btnAddPartTime_Click(object sender, EventArgs e)
        {
            string partTimeName = cboPartTime.Text;
            Dictionary<string, string> PartTimeList = mConfig.GetSectionValues("PartTimeList");

            mConfig.WriteValue(partTimeName, "START_HOUR", dtStart.Value.Hour);
            mConfig.WriteValue(partTimeName, "START_MIN", dtStart.Value.Minute);

            mConfig.WriteValue(partTimeName, "END_HOUR", dtEnd.Value.Hour);
            mConfig.WriteValue(partTimeName, "END_MIN", dtEnd.Value.Minute);

            mConfig.WriteValue("PartTimeList", (PartTimeList.Count + 1).ToString(), partTimeName);

            LoadCombo();
        }

        private void btnDelPartTime_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> PartTimeList = mConfig.GetSectionValues("PartTimeList");
            foreach (KeyValuePair<string, string> list in PartTimeList)
            {
                if(cboPartTime.Text == list.Value)
                {
                    mConfig.DeleteSection(list.Value);
                    mConfig.DeleteKey("PartTimeList", list.Key);
                    break;
                }
            }

            int i = 1;
            PartTimeList = mConfig.GetSectionValues("PartTimeList");
            mConfig.DeleteSection("PartTimeList");
            foreach (KeyValuePair<string, string> list in PartTimeList)
            {
                mConfig.WriteValue("PartTimeList", i.ToString(), list.Value);
                i++;
            }

            LoadCombo();
        }

        private void LoadCombo()
        {
            cboPartTime.Text = "";
            cboPartTime.Items.Clear();
            Dictionary<string, string> PartTimeList = mConfig.GetSectionValues("PartTimeList");
            foreach (KeyValuePair<string, string> list in PartTimeList)
            {
                cboPartTime.Items.Add(list.Value);
            }
        }

        private void cboPartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stHour = mConfig.GetInt32(cboPartTime.Text, "START_HOUR", 0);
            int stMin = mConfig.GetInt32(cboPartTime.Text, "START_MIN", 0);

            int endHour = mConfig.GetInt32(cboPartTime.Text, "END_HOUR", 0);
            int endMin = mConfig.GetInt32(cboPartTime.Text, "END_MIN", 0);

            dtStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, stHour, stMin, 0, DateTimeKind.Local);
            dtEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, endHour, endMin, 0, DateTimeKind.Local);

        }
    }
}
