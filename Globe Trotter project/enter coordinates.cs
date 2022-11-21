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
            string ID;
            int nextid;
            bool defaultl = defaultlocaltickbox.Checked;

            string _sSqlString;

            _sSqlString = "SELECT LocationID FROM Location ORDER BY LocationID DESC";

            ID = ReadSql(_sSqlString);
            if (ID == null)
            {
                ID = "10000";
            }
            else
            {
                nextid = Convert.ToInt32(ID) + 1;
                ID = Convert.ToString(nextid);
            }

            

            _sSqlString = "INSERT INTO Location(LocationID, LocationName, Long_coords, Lat_coords) " +
               " Values('" + ID + "', '" + name + "', '" + Locoords + "','" + Lacoords + "')";
            ExecuteSql(_sSqlString);

            if (defaultl)
            {

            }


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

        private void freqlocaldd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coordsfr_Load(object sender, EventArgs e)
        {
            freqlocalgb.Hide();
        }
    }
}
