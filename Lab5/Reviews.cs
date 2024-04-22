using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Models:
Traveler(name,contactDetails,preferences) DONE
reviews(rating,Traveler) DONE

trip(traveler,date,activities,accomedations,destination,additionalCost) 
destination(name,location,cost)

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
    public class Reviews
    {
        OleDbConnection myConnection;
        Traveler traveler;
        int rating;
        string comments;
        public Reviews(Traveler traveler,int rating,string comments)
        {
            this.traveler = traveler;
            this.rating = rating;
            this.comments = comments;
        }
        public void saveReview()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();

            String query = "INSERT INTO reviews ([travelerName], [rating], [comments]) " +
                           "VALUES (@travelerName, @rating, @comments)";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@travelerName", this.traveler.getName());
            cmd.Parameters.AddWithValue("@rating", this.rating);
            cmd.Parameters.AddWithValue("@comments", this.comments);

            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void loadReview(string nameSearch)
        {

            string query = "SELECT * " +
              "FROM reviews " +
              "WHERE [travelerName] = @travelerName";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@travelerName", nameSearch);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.traveler.loadTraveler(nameSearch);
                this.rating = reader.GetInt32(reader.GetOrdinal("rating"));
                this.comments = reader.GetString(reader.GetOrdinal("comments"));
            }
            reader.Close();
            myConnection.Close();
        }
        public void deleteReview(string name)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "DELETE FROM reviews WHERE [travelerName] = @travelerName";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@travelerName", name);

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void updateReview()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "UPDATE reviews SET " +
              "[rating] = @rating, " +
              "[comments] = @comments, " +
              "WHERE [travelerName] = @travelerName";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@rating", this.rating);
            cmd.Parameters.AddWithValue("@comments", this.comments);
            cmd.Parameters.AddWithValue("@travelerName", this.traveler.getName());

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}