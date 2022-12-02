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
            double totaldistance = 0;
            double unitdistance;
            TimeSpan dt;
            List<List<string>> tabledata = new List<List<string>>();

            userIDlb.Text = _logid;

 
            _sSqlString = "SELECT JourneyID, DateofJourney, S.LocationName, E.LocationName, Distance, StartTime, EndTime " +
                "FROM Journey, Location S, Location E WHERE StartLocalID = S.LocationID AND EndLocalID = E.LocationID AND EmployeeID = " + _logid + " AND " +
                "DateofJourney BETWEEN Date() AND Date()-7 ORDER BY JourneyID ASC";

            tabledata = database.ReadSqls(_sSqlString);

            for (int i = 0; i < tabledata.Count; i++)
            {
                List<string> tablerecord = tabledata[i];
                if (tablerecord[4] == null)
                {
                    continue;
                }

                tablerecord[1] = tablerecord[1].Substring(0, 10);

                unitdistance = Convert.ToDouble(tablerecord[4]) * 1.852;
                unitdistance = Math.Round(unitdistance, 2);
                tablerecord[4] = unitdistance.ToString();
                totaldistance += Convert.ToDouble(tablerecord[4]);
                tablerecord[4] = unitdistance + " km";

                dt = Convert.ToDateTime(tablerecord[6]) - Convert.ToDateTime(tablerecord[5]);
                tablerecord[5] = dt.ToString();

                reporttbl.Rows.Add(new object[] { tablerecord[0], tablerecord[1], tablerecord[2], tablerecord[3], tablerecord[4], tablerecord[5] });
            }
            distancelb.Text = (totaldistance + " km").ToString();

        }
    }
}
