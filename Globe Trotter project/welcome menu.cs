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
    public partial class welcomeFr : Form
    {
        public welcomeFr()
        {
            InitializeComponent();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginFr login = new loginFr();
            login.ShowDialog();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void welcomeFr_Load(object sender, EventArgs e)
        {
            CheckDatabase();
        }
        private const string EXAMPLEDB = "ExampleDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        private void CheckDatabase()
        {
            CatalogClass cat = new CatalogClass();
            if (!File.Exists(EXAMPLEDB))
            {

                cat.Create(CONNECTION_STRING);
                createdatabase();
            }
            else
            {

            }
            cat = null;
        }

        void createdatabase()
        {
            string _sSqlString;

            _sSqlString = "CREATE TABLE Location("
                                                + "LocationID SHORT NOT NULL,"
                                                + "LocationName VARCHAR(30),"
                                                + "Long_coords INT,"
                                                + "Lat_coords INT,"
                                                + "PRIMARY KEY (LocationID)"
                                                + ")";
            ExecuteSql(_sSqlString);

            _sSqlString = "CREATE TABLE Employee("
                                               + "EmployeeID SHORT NOT NULL,"
                                               + "EmpPassword INT,"
                                               + "Surname VARCHAR(30),"
                                               + "Email VARCHAR(60),"
                                               + "PRIMARY KEY (EmployeeID)"
                                               + ")";
            ExecuteSql(_sSqlString);

            _sSqlString = "CREATE TABLE Journey ("
                                                + "JourneyID SHORT NOT NULL,"
                                                + "EmployeeID SHORT NOT NULL,"
                                                + "StartLocalID SHORT NOT NULL,"
                                                + "EndLocalID SHORT NOT NULL,"
                                                + "Distance INT,"
                                                + "DateofJourney DATE,"
                                                + "StartTime TIME,"
                                                + "EndTime TIME,"
                                                + "FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),"
                                                + "FOREIGN KEY (StartLocalID) REFERENCES Location(LocationID),"
                                                + "FOREIGN KEY (EndLocalID) REFERENCES Location(LocationID),"
                                                + "PRIMARY KEY (JourneyID)"
                                                + ")";
            ExecuteSql(_sSqlString);
        }

       


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

        private void newemployeebt_Click(object sender, EventArgs e)
        {
            this.Hide();
            newEmployeeFr newEmp = new newEmployeeFr();
            newEmp.ShowDialog();
        }
    }
}
