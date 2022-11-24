using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using ADOX;

namespace Globe_Trotter_project
{
    public partial class welcomeFr : Form
    {
        public welcomeFr()
        {
            InitializeComponent();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginFr login = new loginFr();
            login.ShowDialog();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void welcomeFr_Load(object sender, EventArgs e)
        {
            database.CheckDatabase();
        }
       

       


       


       

        private void newemployeebt_Click(object sender, EventArgs e)
        {
            this.Hide();
            newEmployeeFr newEmp = new newEmployeeFr();
            newEmp.ShowDialog();
        }
    }
}
