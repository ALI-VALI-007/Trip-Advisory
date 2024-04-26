using System;
using System.Collections.Generic;
using System.Data;
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
        int id;
        Traveler traveler;
        int rating;
        string comments;
        string dName;
        public Reviews(int id,Traveler traveler,int rating,string comments, string dName)
        {
            this.id = id;
            this.traveler = traveler;
            this.rating = rating;
            this.comments = comments;
            this.dName = dName;
        }
        public int getId()
        {
            return id;
        }
        public void setTraveler(Traveler traveler)
        {
            this.traveler=traveler;
        }
        public void setRating(int rating)
        {
            this.rating = rating;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setComments(string comments)
        {
            this.comments=comments;
        }
        public void setDName(string dName)
        {
            this.dName=dName;
        }
        public int getRating() 
        {
            return rating; 
        }
        public string getString()
        {
            return this.traveler.getName() +","+ this.rating.ToString() +","+ this.comments;
        }
        public void saveReview()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();

            String query = "INSERT INTO reviews ([id], [travelerName], [rating], [comments], [dName] ) " +
                           "VALUES (@id, @travelerName, @rating, @comments, @dName)";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);
            this.id = findReviewID();
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@travelerName", this.traveler.getName());
            cmd.Parameters.AddWithValue("@rating", this.rating);
            cmd.Parameters.AddWithValue("@comments", this.comments);
            cmd.Parameters.AddWithValue("@dName", this.dName);

            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void loadReviewId(int id)
        {

            string query = "SELECT * " +
              "FROM reviews " +
              "WHERE [id] = @id";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@id", id);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string x = reader.GetString(reader.GetOrdinal("travelerName"));
                this.traveler.loadTraveler(x);
                this.rating = reader.GetInt32(reader.GetOrdinal("rating"));
                this.comments = reader.GetString(reader.GetOrdinal("comments"));
                this.dName = reader.GetString(reader.GetOrdinal("dName"));
            }
            reader.Close();
            myConnection.Close();
        }
        public void loadReview(string nameSearch)
        {

            string query = "SELECT * " +
              "FROM reviews " +
              "WHERE [dName] = @dName";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@dName", nameSearch);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string x = reader.GetString(reader.GetOrdinal("travelerName"));
                this.traveler.loadTraveler(x);
                this.rating = reader.GetInt32(reader.GetOrdinal("rating"));
                this.comments = reader.GetString(reader.GetOrdinal("comments"));
                this.dName = reader.GetString(reader.GetOrdinal("dName"));
            }
            reader.Close();
            myConnection.Close();
        }
        public void deleteReview(int id)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "DELETE FROM reviews WHERE [id] = @id";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@id", id);

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
              "[travelerName] = @travelerName " +
              "[dName] = @dName " +
              "WHERE [id] = @id";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@rating", this.rating);
            cmd.Parameters.AddWithValue("@comments", this.comments);
            cmd.Parameters.AddWithValue("@travelerName", this.traveler.getName());
            cmd.Parameters.AddWithValue("@dName", this.dName);
            cmd.Parameters.AddWithValue("@id", this.id);

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public List<Reviews> loadAllReviews()
        {
            List<Reviews> list = new List<Reviews>();
            string query = "SELECT * " +
              "FROM reviews ";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = cmd.ExecuteReader();
            foreach (var row in reader)
            {
                this.id = reader.GetInt32(reader.GetOrdinal("id"));
                string x = reader.GetString(reader.GetOrdinal("travelerName"));
                this.traveler.loadTraveler(x);
                this.rating = reader.GetInt32(reader.GetOrdinal("rating"));
                this.comments = reader.GetString(reader.GetOrdinal("comments"));
                this.dName = reader.GetString(reader.GetOrdinal("dName"));
                Reviews newReview = new Reviews(id, traveler, rating, comments, dName);
                list.Add(newReview);
            }
            reader.Close();
            myConnection.Close();
            return list;
        }
        public int findReviewID()
        {
            int result = 0;
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();

            string query = "SELECT * FROM reviews;";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            foreach (var row in reader)
            {
                result++;
            }
            reader.Close();
            return result + 1;
        }
        public DataTable loadDGV(string destinationName)
        {

            string query = "SELECT * " +
                            "FROM  reviews " +
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

    }
}