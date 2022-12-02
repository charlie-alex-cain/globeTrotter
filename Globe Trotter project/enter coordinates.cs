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
            double Locoords;
            double Lacoords;
            int start_end;
            bool startcoords = startcoordstickbox.Checked;
            DateTime dt = DateTime.Now;
            string datetime = dt.ToString();
            string date = datetime.Substring(0, 10);
            string time = datetime.Substring(12, 7);
            string _sSqlString;
            double distance;
            string joID = "";
            double Lacoordsstart;
            double Locoordsstart;

            if (frequentlocaltickbox.Checked)
            {
                List<List<string>> locationdata = new List<List<string>>();
                _sSqlString = "SELECT LocationID, Long_coords, Lat_coords FROM Location WHERE LocationName = '" + freqlocaldd.Text + "'";
                locationdata = database.ReadSqls(_sSqlString);
                start_end = Convert.ToInt32(locationdata[0][0]);
                Locoords = Convert.ToDouble(locationdata[0][1]);
                Lacoords = Convert.ToDouble(locationdata[0][2]);

                if (startcoords)
                {
                    _sSqlString = "SELECT JourneyID FROM Journey ORDER BY JourneyID DESC";
                    joID = database.createID(_sSqlString, joID);

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
                    List<List<string>> StartLocationData = new List<List<string>>();
                    _sSqlString = "SELECT JourneyID, Long_coords, Lat_coords FROM Journey, Location WHERE StartLocalID = LocationID ORDER BY JourneyID DESC";
                    StartLocationData = database.ReadSqls(_sSqlString);
                    joID = StartLocationData[0][0];
                    Locoordsstart = Convert.ToDouble(StartLocationData[0][1]);
                    Lacoordsstart = Convert.ToDouble(StartLocationData[0][2]);

                    distance = calcdistance(Lacoordsstart, Locoordsstart, Lacoords, Locoords);

                    _sSqlString = "UPDATE Journey SET EndLocalID = " + start_end + ", EndTime = '" + time + "', Distance = " + distance + " WHERE JourneyID = " + joID;
                    database.ExecuteSql(_sSqlString);

                    this.Hide();
                    mainfr main = new mainfr(_logid);
                    main.ShowDialog();
                }

                freqlocaldd.Text = "";

            }
            else
            {
                Locoords = Convert.ToDouble(long_coordstb.Text);
                Lacoords = Convert.ToDouble(lat_coordstb.Text);
                string name = locationnametb.Text;
                string loID = "";              
                string _lSqlString;

                _sSqlString = "SELECT LocationID FROM Location ORDER BY LocationID DESC";
                loID = database.createID(_sSqlString, loID);

                _sSqlString = "INSERT INTO Location(LocationID, LocationName, Long_coords, Lat_coords) " +
                   " Values('" + loID + "', '" + name + "', " + Locoords + "," + Lacoords + ")";
                database.ExecuteSql(_sSqlString);
                if (addfreqtickbox.Checked)
                {
                    database.addtoFrequentLocations(loID, name, Locoords, Lacoords);
                    addfreqtickbox.Checked = false;
                }

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
                    List<List<string>> StartLocationData = new List<List<string>>();
                    _sSqlString = "SELECT JourneyID, Long_coords, Lat_coords FROM Journey, Location WHERE StartLocalID = LocationID ORDER BY JourneyID DESC";
                    StartLocationData = database.ReadSqls(_sSqlString);
                    joID = StartLocationData[0][0];
                    Locoordsstart = Convert.ToDouble(StartLocationData[0][1]);
                    Lacoordsstart = Convert.ToDouble(StartLocationData[0][2]);

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
        }

        public double calcdistance(double lat1, double lon1, double lat2, double lon2)
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
            locationlist = database.ReadSqls(_sSqlString);

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
    }
}
