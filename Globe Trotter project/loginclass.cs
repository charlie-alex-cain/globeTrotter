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
using System.IO;
using ADOX;

namespace Globe_Trotter_project
{
    internal class loginclass
    {
        string ID;
        string password;
        string email;

        public loginclass(string _ID, string _password, string _email)
        {
            ID = _ID;
            password = _password;
            email = _email;
        }

    }
}

