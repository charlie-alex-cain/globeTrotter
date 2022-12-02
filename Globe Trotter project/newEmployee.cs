using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using ADOX;

namespace Globe_Trotter_project
{
    public partial class newEmployeeFr : Form
    {
       
        public newEmployeeFr()
        {
            InitializeComponent();
        }

        private void emailtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitbt2_Click(object sender, EventArgs e)
        {
            string checkid = "";
            string _sSqlString;
            bool done = false;

            string email = emailtb.Text;
            string Surname = surnametb.Text;
            string pass = newpasstb.Text;
            string repeatpass = newRpasstb.Text;
            int finalpass;
            
            if (pass == repeatpass)
            {
                _sSqlString = "SELECT EmployeeID FROM Employee ORDER BY EmployeeID DESC";
                checkid = database.createID(_sSqlString, checkid);

                finalpass = database.encrypt_pass(pass);               
                _sSqlString = "INSERT INTO Employee(EmployeeID, Emppassword, SurName, Email) " +
                " Values('" + checkid + "', '" + finalpass + "', '" + Surname + "','" + email + "')";
                database.ExecuteSql(_sSqlString);

                MessageBox.Show("your employee ID is " + checkid);

                this.Hide();
                welcomeFr wel = new welcomeFr();
                wel.ShowDialog();
            }
            else
            {
                MessageBox.Show("your password and reapet password do not match please enter identical passwords");
                newpasstb.Clear();
                newRpasstb.Clear();
            }

           

        }

        private void newEmployeeFr_Load(object sender, EventArgs e)
        {

        }

        
       
        

        private void surnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbt4_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeFr wel = new welcomeFr();
            wel.ShowDialog();
        }
    }
}
