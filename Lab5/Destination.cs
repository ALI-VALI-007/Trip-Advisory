using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


ADD PICTURE URL
 */

namespace Lab5
{
    public class Destination
    {
        OleDbConnection myConnection;
        string destinationName;
        string location;
        double cost;
        string URL;
        string attractions;
        public Destination(string destinationName, string location, double cost, string URL, string attractions) {
            this.destinationName = destinationName;
            this.location = location;
            this.cost = cost;
            this.URL = URL;
            this.attractions = attractions;
        }
        public double getCost()
        {
            return cost;
        }
        public string getName()
        {
            return this.destinationName;
        }
        public string getURL()
        {
            return this.URL;
        }
        public string getString()
        {
            return this.destinationName + "," + this.location + "," + this.cost.ToString();
        }
        public string getLocation()
        {
            return this.location;
        }
        public string getAttractions()
        {
            return this.attractions;
        }
        public void saveDestination()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();

            String query = "INSERT INTO destinations ([destinationName], [location], [cost], [URL], [attractions]) " +
                           "VALUES (@destinationName, @location, @cost, @URL, @attractions)";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@destinationName", this.destinationName);
            cmd.Parameters.AddWithValue("@location", this.location);
            cmd.Parameters.AddWithValue("@cost", this.cost);
            cmd.Parameters.AddWithValue("@URL", this.URL);
            cmd.Parameters.AddWithValue("@attractions", this.attractions);

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
                this.cost = convertToDouble(reader.GetDecimal(reader.GetOrdinal("cost")));
                this.URL= reader.GetString(reader.GetOrdinal("URL"));
                this.attractions = reader.GetString(reader.GetOrdinal("attractions"));
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
              "[URL] = @URL, "+
              "[attractions] = @attractions " +
              "WHERE [destinationName] = @destinationName";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@cost", this.cost);
            cmd.Parameters.AddWithValue("@location", this.location);
            cmd.Parameters.AddWithValue("@URL", this.URL);
            cmd.Parameters.AddWithValue("@destinationName", this.destinationName);
            cmd.Parameters.AddWithValue("@attractions", this.attractions);

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        //setters
        public void setCost(Double cost)
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
        public void setURL(string url)
        {
            this.URL = url;
        }
        public void setAttractions(string attractions)
        {
            this.attractions = attractions;
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
                this.cost = convertToDouble(reader.GetDecimal(reader.GetOrdinal("cost")));
                this.URL = reader.GetString(reader.GetOrdinal("URL"));
                this.attractions = reader.GetString(reader.GetOrdinal("attractions"));

                Destination newDestination = new Destination(destinationName, location, cost, URL, attractions);
                list.Add(newDestination);
            }
            reader.Close();
            myConnection.Close();
            return list;
        }
        public DataTable loadDGV(string destinationName)
        {

            string query = "SELECT * " +
                            "FROM  destinations " +
                            "WHERE [destinationName] = @destinationName";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);
            cmd.Parameters.AddWithValue("@destinationName", destinationName);
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            myConnection.Close();
            return dataTable;
        }
        private double convertToDouble(decimal value)
        {
            return (double)value;
        }
        public DataTable filterDestination(double priceFilter, string destinationFilter, string attractionsFilter)
        {
            List<Destination> list = new List<Destination>();
            string query = "SELECT * " +
              "FROM destinations ";
            bool priceFilterExists = priceFilter > 0;
            bool attractionsFilterExists = !string.IsNullOrEmpty(attractionsFilter);
            bool destinationFilterExists = !string.IsNullOrEmpty(destinationFilter);
            List<string> whereQuery = new List<string>();
            if (priceFilterExists || attractionsFilterExists || destinationFilterExists)
            {
                query += "WHERE ";
            }
            if (priceFilterExists)
            {
                whereQuery.Add("[cost] < @priceFilter");
            }
            if (attractionsFilterExists)
            {
                whereQuery.Add("[attractions] = @attractionsFilter");
            }
            if (destinationFilterExists)
            {
                whereQuery.Add("[destinationName] = @destinationFilter");
            }
            string finishedWhereQuery = string.Join(" AND ", whereQuery);
            if( !string.IsNullOrEmpty(finishedWhereQuery) )
            {
                query += finishedWhereQuery;
            //    MessageBox.Show(query);
            }


            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);


            if (priceFilterExists)
            {
                cmd.Parameters.AddWithValue("@priceFilter", priceFilter);
            }
            if (attractionsFilterExists)
            {
                cmd.Parameters.AddWithValue("@attractionsFilter", attractionsFilter);
            }
            if (destinationFilterExists)
            {
                cmd.Parameters.AddWithValue("@destinationFilter", destinationFilter);
            }


            OleDbDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            myConnection.Close();
            return dt;
        }

    }
}
