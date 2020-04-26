using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Salary_Calculator
{
    class Database
    {
        private Utilities.INIFile mConfig = new Utilities.INIFile(Application.StartupPath + "\\Config.ini");

        private MySqlConnection mConnection;
        private MySqlCommand mCommand = new MySqlCommand();
        private MySqlDataReader mDataReader;

        public MySqlConnection Connection
        {
            get { return mConnection; }
            set { mConnection = value; }
        }

        public MySqlCommand Command
        {
            get { return mCommand; }
            set { mCommand = value; }
        }

        public MySqlDataReader DataReader
        {
            get { return mDataReader; }
            set { mDataReader = value; }
        }

        public void OpenDB()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }

        }

        public void ClosedDB()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }

        public void ConnectDB()
        {
            Connection = null;

            try
            {
                string ip = mConfig.GetString("DB", "IP", "127.0.0.1");
                string port = mConfig.GetString("DB", "PORT", "3307");
                string DB = mConfig.GetString("DB", "DB", "SALARY");
                string ID = mConfig.GetString("DB", "ID", "root");
                string PW = mConfig.GetString("DB", "PW", "1234");

                string connectionString = "Server=" + ip + "; Port=" + port + "; Database=" + DB + "; Uid=" + ID + "; Pwd=" + PW + ";";
                Connection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }

        public DataSet GetProcedure(string procedure, string[] columns, string[] data)
        {
            OpenDB();

            MySqlDataAdapter DataAdapter = new MySqlDataAdapter();

            DataSet dataSet = new DataSet();
            DataAdapter.SelectCommand = new MySqlCommand(procedure, Connection);
            DataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < columns.Length; i++)
            {
                DataAdapter.SelectCommand.Parameters.AddWithValue("@IN_" + columns[i], data[i]);
                //DataAdapter.SelectCommand.Parameters["@IN_" + columns[i]].Direction = ParameterDirection.Input;
            }
            //Command.Parameters.AddWithValue("@IN_START_TIME", "2020-04-20 09:00:00");
            //Command.Parameters["@IN_START_TIME"].Direction = ParameterDirection.Input;

            //Command.ExecuteNonQuery();

            DataAdapter.Fill(dataSet);
            DataAdapter.Dispose();

            ClosedDB();

            return dataSet;

        }

        public void SetProcedure(string procedure, string [] columns, string [] data)
        {
            try
            {
                OpenDB();

                Command = new MySqlCommand(procedure, Connection);
                Command.CommandType = CommandType.StoredProcedure;

                for(int i = 0; i < columns.Length; i++)
                {
                    Command.Parameters.AddWithValue("@IN_" + columns[i], data[i]);
                    Command.Parameters["@IN_" + columns[i]].Direction = ParameterDirection.Input;
                }
                //Command.Parameters.AddWithValue("@IN_START_TIME", "2020-04-20 09:00:00");
                //Command.Parameters["@IN_START_TIME"].Direction = ParameterDirection.Input;

                Command.ExecuteNonQuery();

                ClosedDB();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
            }
        }
    }
}
