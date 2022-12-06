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
            double Locoords=0;
            double Lacoords=0;
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
            string name = "";



            if (frequentlocaltickbox.Checked)
            {
                List<List<string>> locationdata = new List<List<string>>();
                _sSqlString = "SELECT LocationID, Long_coords, Lat_coords FROM Location WHERE LocationName = '" + freqlocaldd.Text + "'";
                locationdata = database.ReadSqls(_sSqlString);
                start_end = Convert.ToInt32(locationdata[0][0]);
                Locoords = Convert.ToDouble(locationdata[0][1]);
                Lacoords = Convert.ToDouble(locationdata[0][2]);
            }
            else
            {
                if (long_coordstb.Text == "" || lat_coordstb.Text == "" || locationnametb.Text == "")
                {
                    long_coordstb.Clear();
                    lat_coordstb.Clear();
                    locationnametb.Clear();
                    MessageBox.Show("cordinates or location name where not valid please try again");             
                    return;
                }
                try
                {
                    Locoords = Convert.ToDouble(long_coordstb.Text);
                    Lacoords = Convert.ToDouble(lat_coordstb.Text);
                    name = locationnametb.Text;                  
                }
                catch
                {
                    lat_coordstb.Clear();
                    long_coordstb.Clear();
                    locationnametb.Clear();
                    MessageBox.Show("cordinates or location name where not valid please try again");
                    return;
                }
                string loID = "";


                if (Locoords > 90 || Locoords < -90 || Lacoords > 180 || Lacoords < -180)
                {
                    long_coordstb.Clear();
                    lat_coordstb.Clear();
                    MessageBox.Show("the coordinates you entered where invalid please try again");
                    return;
                }

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
            }

            if (startcoords)
            {
                _sSqlString = "SELECT JourneyID FROM Journey ORDER BY JourneyID DESC";
                joID = database.createID(_sSqlString, joID);

                _sSqlString = "INSERT INTO Journey(JourneyID, EmployeeID, StartLocalID, DateofJourney, StartTime) " +
                " Values('" + joID + "','" + _logid + "', '" + start_end + "','" + date + "','" + time + "')";
                database.ExecuteSql(_sSqlString);

                startcoordstickbox.Checked = false;
                start_endlb.Text = "coordinates entered will be for END location";

                MessageBox.Show("your JourneyID is " + joID);
            }

            if (startcoords == false)
            {
                List<List<string>> StartLocationData = new List<List<string>>();
                _sSqlString = "SELECT JourneyID, Long_coords, Lat_coords FROM Journey, Location " +
                    "WHERE EmployeeID = " + _logid + " AND StartLocalID = LocationID ORDER BY JourneyID DESC";
                StartLocationData = database.ReadSqls(_sSqlString);
                joID = StartLocationData[0][0];
                Locoordsstart = Convert.ToDouble(StartLocationData[0][1]);
                Lacoordsstart = Convert.ToDouble(StartLocationData[0][2]);

                distance = calcdistance(Lacoordsstart, Locoordsstart, Lacoords, Locoords);

                _sSqlString = "UPDATE Journey SET EndLocalID = " + start_end + ", EndTime = '" + time + "', Distance = " + distance + " " +
                    "WHERE JourneyID = " + joID + " AND EmployeeID = " + _logid;
                database.ExecuteSql(_sSqlString);

                this.Hide();
                mainfr main = new mainfr(_logid);
                main.ShowDialog();
            }

            freqlocaldd.Text = "";
            lat_coordstb.Clear();
            long_coordstb.Clear();
            locationnametb.Clear();
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
            distance = distance * 1.852;
            distance = Math.Round(distance, 2);
            return distance;
        }
  
        private void coordsfr_Load(object sender, EventArgs e)
        {
            freqlocalgb.Hide();

            startcoordstickbox.Hide();
            startcoordstickbox.Checked = true;
            string _sSqlString;
            string check;
            _sSqlString = "SELECT EndLocalID FROM Journey WHERE EmployeeID = " + _logid + " ORDER BY JourneyID DESC";
            check = database.ReadSql(_sSqlString);
            if (check == "")
            {
                startcoordstickbox.Checked = false;
                start_endlb.Text = "coordinates entered will be for END location";
            }

            int numrecords;
            List<List<string>> locationlist = new List<List<string>>();       
            _sSqlString = "SELECT LocationName FROM Location ORDER BY LocationName ASC";
            locationlist = database.ReadSqls(_sSqlString);

            numrecords = locationlist.Count;
            System.Object[] locallist = new System.Object[numrecords];

            for (int i = 0; i < numrecords; i++)
            {
                List<string> locallisttemp = locationlist[i];
                locallist[i] = locallisttemp[0];

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
