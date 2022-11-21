using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globe_Trotter_project
{
    internal class Journeyclass
    {
        int Slocation;
        int Elocation;
        int distance;
        DateTime Date = new DateTime();

        public Journeyclass(int _Slocation, int _Elocation, int _distance, DateTime _Date = new DateTime())
        {
            Slocation = _Slocation;
            Elocation = _Elocation;
            distance = _distance;
            Date = _Date;
        }
    }
}
