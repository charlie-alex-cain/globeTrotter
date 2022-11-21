using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globe_Trotter_project
{
    internal class Locationclass
    {
        string LocationID;
        string name;
        double long_coords;
        double lat_coords;
       

        public Locationclass(string _locationID, string _name, double _long_coords, double _lat_coords)
        {
            LocationID = _locationID;
            name = _name;
            long_coords = _long_coords;
            lat_coords = _lat_coords;
        }

    }
}
