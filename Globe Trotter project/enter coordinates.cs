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
        public coordsfr()
        {
            InitializeComponent();
        }
        bool startenter = true;
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
            string loID;
            string joID;
            int nextid;
            bool defaultl = defaultlocaltickbox.Checked;

            

            string _sSqlString;
            string _lSqlString;

            _sSqlString = "SELECT LocationID FROM Location ORDER BY LocationID DESC";
            _lSqlString = "SELECT JourneyID FROM Journey ORDER BY JourneyID DESC";

            loID = database.ReadSql(_sSqlString);
            if (loID == null)
            {
                loID = "10000";
            }
            else
            {
                nextid = Convert.ToInt32(loID) + 1;
                loID = Convert.ToString(nextid);
            }

            

            _sSqlString = "INSERT INTO Location(LocationID, LocationName, Long_coords, Lat_coords) " +
               " Values('" + loID + "', '" + name + "', '" + Locoords + "','" + Lacoords + "')";
            database.ExecuteSql(_sSqlString);

            

            

            int start_end;
            start_end = Convert.ToInt32(loID);
            int currentJoID;
            
            joID = database.ReadSql(_lSqlString);
            currentJoID = Convert.ToInt32(joID);
            if (joID == null)
            {
                joID = "10000";
            }
            else
            {
                
                nextid = Convert.ToInt32(joID) + 1;
                joID = Convert.ToString(nextid);              
            }
            
            if (startenter == false)
            {

               // _sSqlString = "INSERT INTO Journey(EndLocalID) " +
               //" Values('" + start_end + "')";
                _sSqlString = "UPDATE Journey SET EndLocalID = " + start_end+ " WHERE JourneyID = " + currentJoID ;

                database.ExecuteSql(_sSqlString);

                
            }


            if (defaultl == true)
            {
                startenter = false;
            }
            else
            {
                if (startenter)
                {
                    

                    _sSqlString = "INSERT INTO Journey(JourneyID, StartLocalID) " +
                   " Values('" + joID + "', '" + start_end + "')";
                    database.ExecuteSql(_sSqlString);

                    startenter = false;
                }
            }

            

            lat_coordstb.Clear();
            long_coordstb.Clear();
            locationnametb.Clear();


        }


        
       

        private void freqlocaldd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coordsfr_Load(object sender, EventArgs e)
        {
            freqlocalgb.Hide();
            
        }
    }
}
