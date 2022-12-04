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
    public partial class mainfr : Form
    {
        string _logid;
        public mainfr(string logid)
        {
            InitializeComponent();
            _logid = logid;
        }
        private void logoutbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeFr wel = new welcomeFr();
            wel.ShowDialog();
        }

        private void coordsbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            coordsfr coords = new coordsfr(_logid);
            coords.ShowDialog();
        }

        private void reportbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            weekreportfr report = new weekreportfr(_logid);
            report.ShowDialog();
        }

        private void journeyviewbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            journeyviewfr view = new journeyviewfr(_logid);
            view.ShowDialog();
        }
    }
}
