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
            List<string> tabledata = new List<string>();
            userIDlb.Text = _logid;

            _sSqlString = "SELECT JourneyID, DateofJourney, StartLocalID, EndLocalID, Distance, StartTime, EndTime " +
                "FROM Journey WHERE  EmployeeID =" + _logid + " ORDER BY DateofJourney DESC";
            tabledata = ReadSql(_sSqlString);
            tabledata[1] = tabledata[1].Substring(0,10);

            _sSqlString = "SELECT LocationName FROM Location WHERE LocationID = " + tabledata[2];
            tabledata[2] = database.ReadSql(_sSqlString);

            _sSqlString = "SELECT LocationName FROM Location WHERE LocationID = " + tabledata[3];
            tabledata[3] = database.ReadSql(_sSqlString);

            unitdistance = Convert.ToDouble(tabledata[4]) * 1.852;
            unitdistance = Math.Round(unitdistance, 2);
            tabledata[4] = unitdistance.ToString();
            tabledata[4] = unitdistance + " km";

            dt = Convert.ToDateTime(tabledata[6]) - Convert.ToDateTime(tabledata[5]);
            tabledata[5] = dt.ToString();  
            
            reporttbl.Rows.Add(new object[] { tabledata[0], tabledata[1], tabledata[2], tabledata[3], tabledata[4], tabledata[5] });
            

        }

        private void userIDlb_Click(object sender, EventArgs e)
        {

        }

        private const string EXAMPLEDB = "ExampleDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";
        public static List<string> ReadSql(String sSqlString)
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
                            string readed;
                            
                            List<string> SQl = new List<string>(10);
                            
                            for (int i = 0; i < 7; i++)
                            {
                                readed = reader.GetValue(i).ToString();
                                SQl.Add(readed);
                            }
                            return SQl;
                           
                        }
                        else
                        {
                            return null;
                        }



                    }
                    catch (Exception ex)
                    {
                        List<string> SQl = new List<string>();
                        
                        SQl.Add("error1");
                        return SQl;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
