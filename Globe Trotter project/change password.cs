using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Globe_Trotter_project
{
    public partial class changepassfr : Form
    {
        public changepassfr()
        {
            InitializeComponent();
        }

        private void submitbt4_Click(object sender, EventArgs e)
        {
            string pass = newpasstb.Text;
            string rpass = rnewpasstb.Text;
            string ID = useridtb.Text;
            int finalnewpass;
            string _sSqlString;
            bool correct = false;
            List<List<string>> IDcheck = new List<List<string>>();

            _sSqlString = "SELECT EmployeeID FROM Employee ORDER BY EmployeeID ASC";
            IDcheck = database.ReadSqls(_sSqlString);

            for (int i = 0; i < IDcheck.Count; i++)
            {
                if (IDcheck[i][0] == ID)
                {
                    correct = true;
                }
            }

            if (correct)
            {
                string oldpass = oldpasstb.Text;
                int encryptoldpass;
                int oldpasscheck;
                encryptoldpass = database.encrypt_pass(oldpass);
                _sSqlString = "SELECT EmpPassword FROM Employee WHERE EmployeeID = " + ID;
                oldpasscheck = Convert.ToInt32(database.ReadSql(_sSqlString));

                if (encryptoldpass == oldpasscheck)
                {
                    if (pass == rpass)
                    {
                        finalnewpass = database.encrypt_pass(pass);
                        _sSqlString = "UPDATE Employee SET EmpPassword = " + finalnewpass + " WHERE EmployeeID = " + ID;
                        database.ExecuteSql(_sSqlString);

                        MessageBox.Show("your password was changed successfully");
                        this.Hide();
                        welcomeFr wel = new welcomeFr();
                        wel.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("your password and reapet password do not match please enter identical passwords");
                        newpasstb.Clear();
                        rnewpasstb.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("your old password was incorrect please try again");
                    oldpasstb.Clear();
                }
            }
            else
            {
                MessageBox.Show("an invalid ID was entered try again");
                useridtb.Clear();
            }
        }

        private void backbt3_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeFr wel = new welcomeFr();
            wel.ShowDialog();
        }
    }
}
