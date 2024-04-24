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

trip(traveler,date,activities,accomedations,destination,additionalCost)  
destination(name,location,cost) DONE

Controllers:
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
    public class Destination
    {
        OleDbConnection myConnection;
        string destinationName;
        string location;
        float cost;
        public Destination(string destinationName, string location, float cost) {
            this.destinationName = destinationName;
            this.location = location;
            this.cost = cost;
        }
        public string getString()
        {
            return this.destinationName + "," + this.location + "," + this.cost.ToString();
        }
        public string getLocation()
        {
            return this.location;
        }
        public void saveDestination()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();

            String query = "INSERT INTO destinations ([destinationName], [location], [cost]) " +
                           "VALUES (@destinationName, @location, @cost)";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@destinationName", this.destinationName);
            cmd.Parameters.AddWithValue("@location", this.location);
            cmd.Parameters.AddWithValue("@cost", this.cost);

            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void loadDestination(string nameSearch)
        {
            this.destinationName = nameSearch;
            string query = "SELECT * " +
              "FROM destinations " +
            "WHERE [destinationName] = @destinationName";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);
            
            cmd.Parameters.AddWithValue("@destinationName", nameSearch);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.location = reader.GetString(reader.GetOrdinal("location"));
                this.cost = reader.GetFloat(reader.GetOrdinal("cost"));
            }
            reader.Close();
            myConnection.Close();
        }
        public void deleteDestination(string destinationName)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "DELETE FROM destinations WHERE [destinationName] = @destinationName";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@destinationName", destinationName);

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void updateDestination()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "UPDATE destinations SET " +
              "[cost] = @cost, " +
              "[location] = @comments, " +
              "WHERE [destinationName] = @destinationName";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@cost", this.cost);
            cmd.Parameters.AddWithValue("@location", this.location);
            cmd.Parameters.AddWithValue("@destinationName", this.destinationName);

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        //setters
        public void setCost(float cost)
        {
            this.cost = cost;
        }
        public void setLocation(string location)
        {
            this.location = location;
        }
        public void setDestinationName(string destinationName)
        {
            this.destinationName=destinationName;
        }

        public List<Destination> loadAllDestinations()
        {
            List<Destination> list = new List<Destination>();
            string query = "SELECT * " +
              "FROM destinations ";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = cmd.ExecuteReader();
            foreach (var row in reader)
            {
                this.destinationName = reader.GetString(reader.GetOrdinal("destinationName"));
                this.location = reader.GetString(reader.GetOrdinal("location"));
                this.cost = reader.GetFloat(reader.GetOrdinal("cost"));
                Destination newDestination = new Destination(destinationName, location, cost);
                list.Add(newDestination);
            }
            reader.Close();
            myConnection.Close();
            return list;
        }
    }
}
