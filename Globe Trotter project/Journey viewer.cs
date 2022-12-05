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
    public partial class journeyviewfr : Form
    {
        string _logid;
        public journeyviewfr(string logid)
        {
            InitializeComponent();
            _logid = logid;
        }

        private void backbt6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainfr main = new mainfr(_logid);
            main.ShowDialog();
        }

        private void journeyviewfr_Load(object sender, EventArgs e)
        {
            journeydetailsgb.Hide();

            int numrecords;
            string _sSqlString;
            List<List<string>> IDlist = new List<List<string>>();
            _sSqlString = "SELECT JourneyID FROM Journey WHERE EmployeeID = " + _logid + " ORDER BY JourneyID ASC";
            IDlist = database.ReadSqls(_sSqlString);

            numrecords = IDlist.Count;
            System.Object[] idlist = new System.Object[numrecords];

            for (int i = 0; i < numrecords; i++)
            {
                List<string> locallist = IDlist[i];
                idlist[i] = locallist[0];

            }
            journeyiddd.Items.AddRange(idlist);
        }

        private void submitbt5_Click(object sender, EventArgs e)
        {
            string journeyID = journeyiddd.Text;
            string _sSqlString;
            string date;
            string distance;
            string latstart;
            string lonstart;
            string latend;
            string lonend;
            bool correct = false;
            string webcallcoords;
            List<List<string>> journeydata = new List<List<string>>();
            List<List<string>> ID = new List<List<string>>();

            _sSqlString = "SELECT journeyID, EndLocalID FROM Journey ORDER BY journeyID ASC";
            ID = database.ReadSqls(_sSqlString);

            for (int i = 0; i < ID.Count; i++)
            {
                if (ID[i][0] == journeyID)
                {
                    if(ID[i][1] == "")
                    {
                        break;
                    }
                    correct = true;
                }
            }

            if (correct)
            {
                _sSqlString = "SELECT DateofJourney, S.LocationName, S.Lat_coords, S.Long_coords, E.LocationName, E.Lat_coords, E.Long_coords, Distance " +
               "FROM Journey, Location S, Location E WHERE StartLocalID = S.LocationID AND EndLocalID = E.LocationID AND JourneyID = " + journeyID;
                journeydata = database.ReadSqls(_sSqlString);

                enteridgb.Hide();
                latstart = journeydata[0][2];
                lonstart = journeydata[0][3];
                latend = journeydata[0][5];
                lonend = journeydata[0][6];

                //webcallcoords = "https://maps.googleapis.com/maps/api/staticmap?&size=425x360&markers=size:mid%7Ccolor:red%7C" + latstart + "," +
                //    lonstart + "%7C" + latend + "," + lonend + "&path=color:darkblue%7C" + latstart + "," + lonstart + "%7C" + latend + "," + lonend +
                //    "&key=AIzaSyDrem7PePLwZum3Ed9kCZNAZ1EsYjFVpCY";
                //journeyfinderwb.Navigate(webcallcoords);

                location1lb.Text = journeydata[0][1];
                location2lb.Text = journeydata[0][4];
                distance = Convert.ToString(journeydata[0][7]) + " km";
                distancelb.Text = distance;
                date = journeydata[0][0].ToString().Substring(0, 10);
                datelb.Text = date;
                journeydetailsgb.Show();
                journeyiddd.Text = "";
            }
            else
            {
                MessageBox.Show("an invalid JourneyID was entered please try asgain");
                journeyiddd.Text = "";
            }
        }

        private void donebt_Click(object sender, EventArgs e)
        {
            journeydetailsgb.Hide();
            enteridgb.Show();
        }
    }
}
