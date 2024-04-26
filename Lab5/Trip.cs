using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Models:
Traveler(name,contactDetails,preferences) DONE
reviews(rating,Traveler) DONE

trip(traveler,date,activities,accomedations,destination,additionalCost) DONE
destination(name,location,cost) DONE

Controllers: - error handling to all queries, 
travellerController 
tripController
Travel Management Application:
An application to help create, organize, and manage trips 

Functions:
A form for travelers to create profiles with information such as name, contact details, travel preferences, etc.
A form to add new destinations with details like location, attractions, accommodations, etc.
A form to plan trips, selecting destinations, dates, activities, and accommodations.
A form for travelers to leave reviews.
A form for cost estimations of the trip.
A form for creating reviews of destinations
A form for searching for reviews of a destination 
 */

namespace Lab5
{
    public class Trip
    {
        OleDbConnection myConnection;
        int idNumber;
        string dateMade;
        string activities;
        string accomedations;
        string destination;
        double additionalCost;
        string tName;
        string status;
        string careTaker;
        string dateOver;
        //None,txt,none,none,cbx,txt,none,none,txt,txt
        //cbx,txt,none,none,cbx,txt,none,cbx,txt,txt
        //cbx-for destination
        public Trip(int idNumber,string dateMade, string activities, string accomendations, string destination, double additionalCost, string tName, string status, string careTaker, string dateOver)
        {
            this.idNumber = idNumber;
            this.dateMade = dateMade;
            this.activities = activities;
            this.accomedations = accomendations;
            this.destination = destination;
            this.additionalCost = additionalCost;
            this.tName = tName;
            this.status = status;
            this.careTaker = careTaker;
            this.dateOver = dateOver;
        }
        public string getString()
        {
            return this.tName + ","+ this.dateMade +","+ this.dateOver + ","+ this.activities +","+ this.accomedations +","+ this.destination +","+ this.additionalCost.ToString();
        }
        public double getCost()
        {
            return this.additionalCost;
        }
        public int getID()
        {
            return this.idNumber;
        }
        public string getDateMade()
        {
            return this.dateMade;
        }
        public void saveTrip()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source   =lab5DB.accdb;");
            myConnection.Open();

            String query = "INSERT INTO trips ([idNumber], [dateMade], [activities], [accomedations], [destination], [additionalCost], [tName], [status], [careTaker], [dateOver]) " +
                           "VALUES (@idNumber, @dateMade, @activities, @accomedations, @destination, @additionalCost, @tName, @status, @careTaker, @dateOver)";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);
            this.idNumber = findTripID();
            cmd.Parameters.AddWithValue("@idNumber", this.idNumber);
            cmd.Parameters.AddWithValue("@dateMade", this.dateMade);
            cmd.Parameters.AddWithValue("@activities", this.activities);
            cmd.Parameters.AddWithValue("@accomedations", this.accomedations);
            cmd.Parameters.AddWithValue("@destination", this.destination);
            cmd.Parameters.AddWithValue("@additionalCost", this.additionalCost);
            cmd.Parameters.AddWithValue("@tName", this.tName);
            cmd.Parameters.AddWithValue("@status", this.status);
            cmd.Parameters.AddWithValue("@careTaker", this.careTaker);
            cmd.Parameters.AddWithValue("@dateOver", this.dateOver);

            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void loadTrip(int nameSearch)
        {
            this.idNumber = nameSearch;
            string query = "SELECT * " +
              "FROM trips " +
            "WHERE [tName] = @tName";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@tName", nameSearch);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.dateMade = reader.GetString(reader.GetOrdinal("dateMade"));
                this.activities = reader.GetString(reader.GetOrdinal("activities"));
                this.accomedations = reader.GetString(reader.GetOrdinal("accomedations"));
                this.destination = reader.GetString(reader.GetOrdinal("destination"));
                this.additionalCost = reader.GetFloat(reader.GetOrdinal("additionalCost"));
                this.tName = reader.GetString(reader.GetOrdinal("tName"));
                this.status = reader.GetString(reader.GetOrdinal("status"));
                this.careTaker = reader.GetString(reader.GetOrdinal("careTaker"));
                this.dateOver = reader.GetString(reader.GetOrdinal("dateOver"));
            }
            reader.Close();
            myConnection.Close();
        }
        public void deleteTrip(int name)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "DELETE FROM trips WHERE [idNumber] = @idNumber";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@idNumber", name);

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void updateTrip()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "UPDATE trips SET " +
              "[dateMade] = @dateMade, " +
              "[activities] = @activities, " +
              "[accomedations] = @accomedations, " +
              "[destination] = @destination, " +
              "[additionalCost] = @additionalCost, " +
              "[tName] = @tName, " +
              "[status] = @status, " +
              "[careTaker] = @careTaker, " +
              "[dateOver] = @dateOver " +
              "WHERE [idNumber] = @idNumber";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@dateMade", this.dateMade);
            cmd.Parameters.AddWithValue("@activities", this.activities);
            cmd.Parameters.AddWithValue("@accomedations", this.accomedations);
            cmd.Parameters.AddWithValue("@destination", this.destination);
            cmd.Parameters.AddWithValue("@additionalCost", this.additionalCost);         
            cmd.Parameters.AddWithValue("@tName", this.tName);
            cmd.Parameters.AddWithValue("@status", this.status);
            cmd.Parameters.AddWithValue("@careTaker", this.careTaker);
            cmd.Parameters.AddWithValue("@idNumber", this.idNumber);
            cmd.Parameters.AddWithValue("@dateOver", this.dateOver);
            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public int findTripID()
        {
            int result = 0;
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();

            string query = "SELECT * FROM trips;";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            foreach (var row in reader)
            {
                result++;
            }
            reader.Close();
            return result + 1;
        }

        //All the setter methods
            public void setIdNumber(int idNumber)
            {
                this.idNumber = idNumber;
            }

            public void setDateMade(string dateMade)
            {
                this.dateMade = dateMade;
            }

            public void setActivities(string activities)
            {
                this.activities = activities;
            }

            public void setaccomedations(string accomedations)
            {
                this.accomedations = accomedations;
            }
            public void setDestination(string destination)
            {
                this.destination = destination;
            }
            public void setAdditionalCost(double additionalCost)
            {
                this.additionalCost = additionalCost;
            }
        public void settName(string tName)
        {
            this.tName=tName;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public void setCareTaker(string careTaker)
        {
            this.careTaker = careTaker;
        }
        public void setDateOver(string dateOver)
        {
            this.dateOver = dateOver;
        }
    }
}

