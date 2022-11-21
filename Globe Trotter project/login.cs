﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Globe_Trotter_project
{
    public partial class loginFr : Form
    {
        public loginFr()
        {
            InitializeComponent();
        }

        private void submitbt1_Click(object sender, EventArgs e)
        {
            string logpass = passwordtb.Text;
            string logid = loginIDtb.Text;
            int pass;
            int checkpass;
            string f;

            string _sSqlString;


            _sSqlString = "SELECT EmpPassword FROM Employee WHERE EmployeeID = " + logid;
            f = ReadSql(_sSqlString);
            checkpass = Convert.ToInt32( ReadSql(_sSqlString));
            

            pass = encrypt_pass(logpass);

            if (checkpass == pass)
            {
                MessageBox.Show("your login was successful");
                this.Hide();
                mainfr main = new mainfr();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("your ID or password was incorrect please reenter them");
                passwordtb.Clear();
                loginIDtb.Clear();
            }

           
        }
        int encrypt_pass(string _pass)
        {
            List<char> letters = new List<char>(_pass);
            int total = 0;

            for (int i = 0; i < letters.Count; i++)
            {
                total = total + ((int)letters[i]) * (i + 1);

            }
            return total;

        }
        private const string EXAMPLEDB = "ExampleDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        string ReadSql(String sSqlString)
        {
            OleDbDataReader reader = null;
            using (OleDbConnection connection = new OleDbConnection(CONNECTION_STRING))
            {
                using (OleDbCommand command = new OleDbCommand(sSqlString))
                {
                    command.Connection = connection;
                    try
                    {
                        Console.WriteLine(sSqlString);
                        connection.Open();
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return reader.GetValue(0).ToString();
                        }
                        else
                        {
                            return null;
                        }



                    }
                    catch (Exception ex)
                    {
                        return "error1";
                    }
                }
            }
        }
    }
}