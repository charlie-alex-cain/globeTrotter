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

namespace Globe_Trotter_project
{
    public partial class coordsfr : Form
    {
        string _logid;
        public coordsfr(string logid)
        {
            InitializeComponent();
            _logid = logid;
        }
        
        private void long_coordstb_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void frequentlocaltickbox_CheckedChanged(object sender, EventArgs e)
        {
            bool tick = frequentlocaltickbox.Checked;
            
            if (tick)
            {
                coordsgb.Hide();
                freqlocalgb.Show();
            }
            else
            {
                coordsgb.Show();
                freqlocalgb.Hide();
            }
        }
        
        private void submitbt3_Click(object sender, EventArgs e)
        {
            int Locoords = Convert.ToInt32(long_coordstb.Text);
            int Lacoords = Convert.ToInt32(lat_coordstb.Text);   
            string name = locationnametb.Text;
            string loID = "";
            string joID = "";
            int start_end;
            bool startcoords = startcoordstickbox.Checked;
            DateTime dt = DateTime.Now;
            string datetime = dt.ToString();
            string date = datetime.Substring(0, 10);
            string time = datetime.Substring(12, 7);
            string _sSqlString;
            string _lSqlString;
            string _2SqlString;
            double distance;
            int Lacoordsstart;
            int Locoordsstart;
            string coordsID;


            _sSqlString = "SELECT LocationID FROM Location ORDER BY LocationID DESC";
            loID = database.createID(_sSqlString, loID);

            _sSqlString = "INSERT INTO Location(LocationID, LocationName, Long_coords, Lat_coords) " +
               " Values('" + loID + "', '" + name + "', " + Locoords + "," + Lacoords + ")";
            database.ExecuteSql(_sSqlString);
      
            start_end = Convert.ToInt32(loID);

            if (startcoords)
            {
                _lSqlString = "SELECT JourneyID FROM Journey ORDER BY JourneyID DESC";
                joID = database.createID(_lSqlString, joID);

            }
           

            if (startcoords == true)
            {
                
                _sSqlString = "INSERT INTO Journey(JourneyID, EmployeeID, StartLocalID, DateofJourney, StartTime) " +
                " Values('" + joID + "','" + _logid + "', '" + start_end + "','" + date + "','" + time + "')";
                database.ExecuteSql(_sSqlString);

                startcoordstickbox.Checked = false;
            }

            if (startcoords == false)
            {
                _2SqlString ="SELECT JourneyID FROM Journey ORDER BY JourneyID DESC";
                joID = database.ReadSql(_2SqlString);
                // add default system

                _2SqlString = "SELECT StartLocalID FROM Journey WHERE JourneyID = " + joID;
                coordsID = database.ReadSql(_2SqlString);

                _2SqlString = "SELECT Lat_coords FROM Location WHERE LocationID = " + coordsID;
                Lacoordsstart = Convert.ToInt32(database.ReadSql(_2SqlString));

                _2SqlString = "SELECT Long_coords FROM Location WHERE LocationID = " + coordsID;
                Locoordsstart = Convert.ToInt32(database.ReadSql(_2SqlString));

                distance = calcdistance(Lacoordsstart, Locoordsstart, Lacoords, Locoords);

                _sSqlString = "UPDATE Journey SET EndLocalID = " + start_end + ", EndTime = '" + time + "', Distance = " + distance + " WHERE JourneyID = " + joID;
                database.ExecuteSql(_sSqlString);

                this.Hide();
                mainfr main = new mainfr(_logid);
                main.ShowDialog();
            }
            
            lat_coordstb.Clear();
            long_coordstb.Clear();
            locationnametb.Clear();
        }

        public double calcdistance(int lat1, int lon1, int lat2, int lon2)
        {
            const double earthcircumfrence = 3440.1;
            double lat1R = lat1 * (Math.PI / 180);
            double lon1R = lon1 * (Math.PI / 180);
            double lat2R = lat2 * (Math.PI / 180);
            double lon2R = lon2 * (Math.PI / 180);
            double distance;

            distance = earthcircumfrence * Math.Acos((Math.Sin(lat1R) * Math.Sin(lat2R)) + Math.Cos(lat1R) * Math.Cos(lat2R) * Math.Cos(lon1R - lon2R));
            distance = Math.Round(distance, 2);
            return distance;
        }
        private void freqlocaldd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void coordsfr_Load(object sender, EventArgs e)
        {
            freqlocalgb.Hide();

            string _sSqlString;
            int numrecords;
            List<List<string>> locationlist = new List<List<string>>();       
            _sSqlString = "SELECT LocationName FROM Location ORDER BY LocationName ASC";
            locationlist = ReadSqlss(_sSqlString);

            numrecords = locationlist.Count;
            System.Object[] locallist = new System.Object[numrecords];

            for (int i = 0; i < numrecords; i++)
            {
                List<string> locallistp = locationlist[i];
                locallist[i] = locallistp[0];

            }
            freqlocaldd.Items.AddRange(locallist);
        }

        private void backbt2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainfr main = new mainfr(_logid);
            main.ShowDialog();
        }
        private const string EXAMPLEDB = "ExampleDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";

        public static List<List<string>> ReadSqlss(String sSqlString)
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
                            for (int i = 0; i < 1; i++)
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
    }
}
