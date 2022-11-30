using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ADOX;


namespace Globe_Trotter_project
{
    public partial class weekreportfr : Form
    {
        string _logid;
        public weekreportfr(string logid)
        {
            InitializeComponent();
            _logid = logid;
        }

        private void exitbt2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            mainfr main = new mainfr(_logid);
            main.ShowDialog();
        }

        private void weekreportfr_Load(object sender, EventArgs e)
        {
            
            string _sSqlString;
            double unitdistance;
            TimeSpan dt;
            List<List<string>> tabledata = new List<List<string>>();


            userIDlb.Text = _logid;


            _sSqlString = "SELECT JourneyID, DateofJourney, StartLocalID, EndLocalID, Distance, StartTime, EndTime " +
                "FROM Journey WHERE  EmployeeID =" + _logid + " ORDER BY DateofJourney DESC";
            tabledata = ReadSqls(_sSqlString);

            for (int i = 0; i < tabledata.Count; i++)
            {
                List<string> tablerecord = tabledata[i];


                tablerecord[1] = tablerecord[1].Substring(0, 10);

                _sSqlString = "SELECT LocationName FROM Location WHERE LocationID = " + tablerecord[2];
                tablerecord[2] = database.ReadSql(_sSqlString);

                _sSqlString = "SELECT LocationName FROM Location WHERE LocationID = " + tablerecord[3];
                tablerecord[3] = database.ReadSql(_sSqlString);

                unitdistance = Convert.ToDouble(tablerecord[4]) * 1.852;
                unitdistance = Math.Round(unitdistance, 2);
                tablerecord[4] = unitdistance.ToString();
                tablerecord[4] = unitdistance + " km";

                dt = Convert.ToDateTime(tablerecord[6]) - Convert.ToDateTime(tablerecord[5]);
                tablerecord[5] = dt.ToString();

                reporttbl.Rows.Add(new object[] { tablerecord[0], tablerecord[1], tablerecord[2], tablerecord[3], tablerecord[4], tablerecord[5] });
            }

        }

        private void userIDlb_Click(object sender, EventArgs e)
        {

        }

        private const string EXAMPLEDB = "ExampleDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";
        public static List<List<string>> ReadSqls(String sSqlString)
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
                        List<List<string>> Results = new List<List<string>>();
                        while (reader.Read())
                        {
                            List<string> SQl = new List<string>();
                            for (int i = 0; i < 7; i++)
                            {
                               
                                SQl.Add(reader.GetValue(i).ToString());
                            }
                            Results.Add(SQl);
                   
                        }
                        return Results;                  
                    }
                    catch (Exception ex)
                    {
                        List<List<string>> Results = new List<List<string>>();
                        return Results;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
