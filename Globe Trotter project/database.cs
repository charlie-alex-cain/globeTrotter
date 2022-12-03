using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using ADOX;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Globe_Trotter_project
{
    public static class database
    {
        private const string EXAMPLEDB = "ExampleDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " + EXAMPLEDB + ";";
        public static void CheckDatabase()
        {
            CatalogClass cat = new CatalogClass();
            if (!File.Exists(EXAMPLEDB))
            {

                cat.Create(CONNECTION_STRING);
                createdatabase();
                loadFrequentLocations();
                loadbaseusers();
                loadcommonJourneys();
            }
            else
            {

            }
            cat = null;
        }
        private static void loadFrequentLocations()
        {
            string[] readfirst = File.ReadAllLines("frequent locations.txt");
            for (int j = 0; j < readfirst.Length; j++)
            {
                string line = readfirst[j];
                string[] read = line.Split(' ');
                string _sSqlString;

                string LocationID = read[0];
                string LocationName = read[1];
                double Lat_coords = Convert.ToDouble(read[2]);
                double Long_coords = Convert.ToDouble(read[3]);

                _sSqlString = "INSERT INTO Location(LocationID, LocationName, Long_coords, Lat_coords) " +
                       " Values('" + LocationID + "','" + LocationName + "', '" + Long_coords + "','" + Lat_coords + "')";
                ExecuteSql(_sSqlString);
            }
        }
        private static void loadbaseusers()
        {
            string[] readfirst = File.ReadAllLines("base users.txt");
            for (int j = 0; j < readfirst.Length; j++)
            {
                string line = readfirst[j];
                string[] read = line.Split(' ');
                string _sSqlString;

                string EmployeeID = read[0];
                int EmpPassword = Convert.ToInt32(read[1]);
                string Surname = read[2];

                _sSqlString = "INSERT INTO Employee(EmployeeID, EmpPassword, Surname) " +
                       " Values('" + EmployeeID + "','" + EmpPassword + "', '" + Surname + "')";
                ExecuteSql(_sSqlString);
            }
        }

        private static void loadcommonJourneys()
        {
            string[] readfirst = File.ReadAllLines("common Journeys.txt");
            for (int j = 0; j < readfirst.Length; j++)
            {
                string line = readfirst[j];
                string[] read = line.Split(' ');
                string _sSqlString;

                string JourneyID = read[0];
                string EmployeeID = read[1];
                string StartLocalID = read[2];
                string EndLocalID = read[3];
                double Distance = Convert.ToDouble(read[4]);
                string DateofJourney = read[5];
                string StartTime = read[6];
                string EndTime = read[7];

                _sSqlString = "INSERT INTO Journey(JourneyID, EmployeeID, StartLocalID, EndLocalID, Distance, DateofJourney, StartTime , EndTime)" +
                       " Values('" + JourneyID + "','" + EmployeeID + "', '" + StartLocalID + "','" + EndLocalID + "','" + Distance + "','" + DateofJourney + "'" +
                       ",'" + StartTime + "','" + EndTime + "')";
                ExecuteSql(_sSqlString);
            }
        }

        public static void addtoFrequentLocations(string loID, string name, double Locoords, double Lacoords)
        {
            string file = "frequent locations.txt";
            string edit = loID + " " + name + " " + Lacoords + " " + Locoords;
            StreamWriter SR = new StreamWriter(file, true);
            SR.WriteLine("");
            SR.Write(edit);
            SR.Close();
        }
        private static void createdatabase()
        {
            string _sSqlString;

            _sSqlString = "CREATE TABLE Location("
                                                + "LocationID SHORT NOT NULL,"
                                                + "LocationName VARCHAR(30),"
                                                + "Long_coords DOUBLE,"
                                                + "Lat_coords DOUBLE,"
                                                + "PRIMARY KEY (LocationID)"
                                                + ")";
            ExecuteSql(_sSqlString);

            _sSqlString = "CREATE TABLE Employee("
                                               + "EmployeeID SHORT NOT NULL,"
                                               + "EmpPassword INT,"
                                               + "Surname VARCHAR(30),"
                                               + "PRIMARY KEY (EmployeeID)"
                                               + ")";
            ExecuteSql(_sSqlString);

            _sSqlString = "CREATE TABLE Journey("
                                                + "JourneyID SHORT NOT NULL,"
                                                + "EmployeeID SHORT,"
                                                + "StartLocalID SHORT,"
                                                + "EndLocalID SHORT,"
                                                + "Distance DOUBLE,"
                                                + "DateofJourney DATE,"
                                                + "StartTime TIME,"
                                                + "EndTime TIME,"
                                                + "FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),"
                                                + "FOREIGN KEY (StartLocalID) REFERENCES Location(LocationID),"
                                                + "FOREIGN KEY (EndLocalID) REFERENCES Location(LocationID),"
                                                + "PRIMARY KEY (JourneyID)"
                                                + ")";
            ExecuteSql(_sSqlString);
        }


        public static void ExecuteSql(String sSqlString)
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


        public static string ReadSql(String sSqlString)
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

        public static List<List<string>> ReadSqls(String sSqlString)
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
                        List<List<string>> Results = new List<List<string>>();
                        while (reader.Read())
                        {
                            List<string> SQl = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                SQl.Add(reader.GetValue(i).ToString());
                            }
                            Results.Add(SQl);
                        }
                        return Results;
                    }
                    catch (Exception ex)
                    {
                        List<List<string>> Results = new List<List<string>>();
                        Console.WriteLine("error2");
                        return Results;

                    }
                }
            }
        }
        public static string createID(string _sSqlString, string ID)
        {
            int nextid;
            ID = ReadSql(_sSqlString);
            if (ID == null)
            {
                ID = "10000";
                return ID;
            }
            else
            {
                nextid = Convert.ToInt32(ID) + 1;
                ID = Convert.ToString(nextid);
                return ID;
            }
        }
        public static int encrypt_pass(string _pass)
        {
            List<char> letters = new List<char>(_pass);
            int total = 0;

            for (int i = 0; i < letters.Count; i++)
            {
                total = total + ((int)letters[i]) * (i + 1);
            }
            return total;
        }
    }
}
