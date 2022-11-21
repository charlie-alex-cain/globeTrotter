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
        public mainfr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeFr welcome = new welcomeFr();
            welcome.ShowDialog();
        }

        private void coordsbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            coordsfr coords = new coordsfr();
            coords.ShowDialog();
        }
    }
}
