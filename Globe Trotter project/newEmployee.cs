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
            string checkid;
            int nextId;
            string _sSqlString;
            bool done = false;

            _sSqlString = "SELECT EmployeeID FROM Employee ORDER BY EmployeeID DESC";

            checkid = ReadSql(_sSqlString);
            if(checkid == null)
            {
                checkid = "10000";
            }
            else
            {
                nextId = Convert.ToInt32(checkid) + 1;
                checkid = Convert.ToString(nextId);
            }

            string email = emailtb.Text;
            string Surname = surnametb.Text;
            string pass = newpasstb.Text;
            string repeatpass = newRpasstb.Text;
            int finalpass;
            
            if (pass == repeatpass)
            {
                finalpass = encrypt_pass(pass);               
                _sSqlString = "INSERT INTO Employee(EmployeeID, Emppassword, SurName, Email) " +
                " Values('" + checkid + "', '" + finalpass + "', '" + Surname + "','" + email + "')";
                ExecuteSql(_sSqlString); 
                done = true;
                
                MessageBox.Show("your employee ID is " + checkid);
            }
            else
            {
                MessageBox.Show("your password and reapet password do not match please enter identical passwords");
                newpasstb.Clear();
                newRpasstb.Clear();
            }

            if (done)
            {
                this.Hide();
                welcomeFr wel = new welcomeFr();
                wel.ShowDialog();
            }

        }

        private void newEmployeeFr_Load(object sender, EventArgs e)
        {

        }

        private const string EXAMPLEDB = "ExampleDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        void ExecuteSql(String sSqlString)
        {
            using (OleDbConnection connection = new OleDbConnection(CONNECTION_STRING))
            {
                using (OleDbCommand command = new OleDbCommand(sSqlString))
                {
                    command.Connection = connection;
                    try
                    {
                        Console.WriteLine(sSqlString);
                        connection.Open();
                        command.ExecuteNonQuery();
                        
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(sSqlString);
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
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

        private void surnametb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
