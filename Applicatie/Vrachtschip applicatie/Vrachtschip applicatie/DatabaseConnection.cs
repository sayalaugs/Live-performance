using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace Vrachtschip_applicatie
{
    public class DatabaseConnection
    {
        public OracleConnection conn;
        string pcn = "system";
        string pw = "22522842";
        int ID;


        // the constructor in which the connectionstring is set
        public DatabaseConnection()
        {
            conn = new OracleConnection();

            conn.ConnectionString = "User Id=" + pcn + ";Password=" + pw + ";Data Source=" + " //localhost/" + ";";
        }

        //voegt een schip toe aan de database
        public bool AddShip(Vrachtschip schip)
        {
            ID = GetInsertID("VrachtschipID", "Vrachtschip");
            ID++;
            string sql = "INSERT INTO Vrachtschip (VrachtschipID, Soort, MaxHoogte, AantalRijen, ContainersPerRij, AantalStroom) Values ( :ID, :Soort, :MaxHoogte, :AantalRijen, :MaxHoogte, :AantalStroom)";

            OracleCommand command = new OracleCommand(sql, conn);

            command.Parameters.Add(":ID", ID);
            command.Parameters.Add(":Soort", schip.Type);
            command.Parameters.Add(":MaxHoogte", schip.MaxHoogte);
            command.Parameters.Add(":AantalRijen", schip.AantalRijen);
            command.Parameters.Add(":ContainersPerRij", schip.ContainersPerRij);
            command.Parameters.Add(":AantalStroom", schip.AantalStroom);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //voegt een bedrijf toe aan de database
        public bool AddCompany(Bedrijf bedrijf)
        {
            ID = GetInsertID("BedrijfsID", "Bedrijf");
            ID++;
            string sql = "INSERT INTO Bedrijf (BedrijfsID, Naam, Contactpersoon, KVKnr) Values ( :ID, :Naam, :Contactpersoon, :KVKnr)";

            OracleCommand command = new OracleCommand(sql, conn);

            command.Parameters.Add(":ID", ID);
            command.Parameters.Add(":Naam", bedrijf.Naam);
            command.Parameters.Add(":Contactpersoon", bedrijf.Contactpersoon);
            command.Parameters.Add(":KVKnr", bedrijf.KVKnr);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool AddContainer(Container container)
        {
            ID = GetInsertID("SHIPCONTAINERID", "ShipContainer");
            ID++;
            string sql = "INSERT INTO ShipContainer (SHIPCONTAINERID, GEWICHT, SOORT, BEDRIJFSID) Values ( :ID, :Gewicht, :Soort, :BedrijfsID)";

            OracleCommand command = new OracleCommand(sql, conn);

            command.Parameters.Add(":ID", ID);
            command.Parameters.Add(":Gewicht", container.Gewicht);
            command.Parameters.Add(":Soort", container.Type.ToString());
            command.Parameters.Add(":BedrijfsID", container.Bedrijf.ID);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //voegt een bestemming toe aan de database
        public bool AddDestination(Bestemming bestemming)
        {
            string sql = "INSERT INTO Bestemming (Naam, Land) Values ( :Naam, :Land)";

            OracleCommand command = new OracleCommand(sql, conn);

            command.Parameters.Add(":Naam", bestemming.Naam);
            command.Parameters.Add(":Land", bestemming.Land);


            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //haalt een bedrijf op uit de database aan de hand van een bedrijfsnaam
        public Bedrijf GetCompany(string companyname)
        {
            String cmd = "Select * from Bedrijf where Naam = :companyname";
            OracleCommand command = new OracleCommand(cmd, conn);
            command.CommandType = System.Data.CommandType.Text;

            command.Parameters.Add(":companyname", companyname);

            try
            {
                conn.Open();
                OracleDataReader reader = command.ExecuteReader();
                reader.Read();
                int BedrijfsID = Convert.ToInt32(reader["BedrijfsID"].ToString());
                string Naam = reader["Naam"].ToString();
                string ContactPersoon = reader["Contactpersoon"].ToString();
                int KVKnr = Convert.ToInt32(reader["KVKnr"]);

                Bedrijf bedrijf = new Bedrijf(Naam, ContactPersoon, KVKnr);
                bedrijf.ID = BedrijfsID;

                return bedrijf;

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        
        //haalt een vrachtschip op uit de database aan de hand van het meegegeven vrachtschip type
        public Vrachtschip GetShip(string ShipType)
        {
            String cmd = "Select * from Vrachtschip where Soort = :ShipType";
            OracleCommand command = new OracleCommand(cmd, conn);
            command.CommandType = System.Data.CommandType.Text;

            command.Parameters.Add(":ShipType", ShipType);

            try
            {
                conn.Open();
                OracleDataReader reader = command.ExecuteReader();
                reader.Read();

                string Soort = reader["SOORT"].ToString();
                int MAXHOOGTE = Convert.ToInt32(reader["MAXHOOGTE"]);
                int AANTALRIJEN = Convert.ToInt32(reader["AANTALRIJEN"]);
                int CONTAINERSPERRIJ = Convert.ToInt32(reader["CONTAINERSPERRIJ"]);
                int AANTALSTROOM = Convert.ToInt32(reader["AANTALSTROOM"]);

                Vrachtschip vrachtschip = new Vrachtschip(Soort, MAXHOOGTE, AANTALRIJEN, CONTAINERSPERRIJ, AANTALSTROOM);

                return vrachtschip;

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        //haalt alle schepen op uit de database
        public List<Vrachtschip> GetAllShips()
        {
            List<Vrachtschip> databaseShips = new List<Vrachtschip>();
            string sql = "Select * FROM Vrachtschip";
            OracleCommand command = new OracleCommand(sql, conn);
            command.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int VrachtschipID = reader.GetInt32(0);
                    string Soort = reader["Soort"].ToString();
                    int MaxHoogte = Convert.ToInt32(reader["MaxHoogte"]);
                    int AantalRijen = Convert.ToInt32(reader["AantalRijen"]);
                    int ContainersPerRij = Convert.ToInt32(reader["ContainersPerRij"]);
                    int AantalStroom = Convert.ToInt32(reader["AantalStroom"]);


                    Vrachtschip vrachtschip = new Vrachtschip(Soort, MaxHoogte, AantalRijen, ContainersPerRij, AantalStroom);
                    vrachtschip.ID = VrachtschipID;
                    databaseShips.Add(vrachtschip);
                }
                return databaseShips;
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        //haalt alle bestemmingen op uit de database
        public List<Bestemming> GetAllDestinations()
        {
            List<Bestemming> databaseDestinations = new List<Bestemming>();
            string sql = "Select * FROM Bestemming";
            OracleCommand command = new OracleCommand(sql, conn);
            command.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    string Naam = reader["Naam"].ToString();
                    string Land = reader["Land"].ToString();


                    Bestemming bestemming = new Bestemming(Naam, Land);
                    databaseDestinations.Add(bestemming);
                }
                return databaseDestinations;
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        //haalt alle bedrijven op uit de database
        public List<Bedrijf> GetAllCompanys()
        {
            List<Bedrijf> databaseCompanys = new List<Bedrijf>();
            string sql = "Select * FROM Bedrijf";
            OracleCommand command = new OracleCommand(sql, conn);
            command.CommandType = System.Data.CommandType.Text;
            try
            {
                conn.Open();
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int BedrijfsID = reader.GetInt32(0);
                    string naam = reader["NAAM"].ToString();
                    string contactpersoon = reader["CONTACTPERSOON"].ToString();
                    int KVKnr = Convert.ToInt32(reader["KVKNR"]);


                    Bedrijf bedrijf = new Bedrijf(naam, contactpersoon, KVKnr);
                    bedrijf.ID = BedrijfsID;
                    databaseCompanys.Add(bedrijf);
                }
                return databaseCompanys;
            }
            catch
            {
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        //haalt het hoogste id op uit een aangegeven tabel
        private int GetInsertID(string ID, string tabelnaam)
        {
            string insertID = "Select Max(" + ID + ") From " + tabelnaam;

            OracleCommand commandID = new OracleCommand(insertID, conn);
            commandID.CommandType = System.Data.CommandType.Text;

            try
            {
                conn.Open();
                OracleDataReader readerMat = commandID.ExecuteReader();
                readerMat.Read();
                int id = readerMat.GetInt32(0);
                return id;
            }
            catch (InvalidCastException)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
