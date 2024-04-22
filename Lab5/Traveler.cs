﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Models:
Traveler(name,contactDetails,preferences) DONE
reviews(rating,Traveler)

trip(traveler,date,activities,accomedations,destination,additionalCost)
destination(name,location,cost)

Controllers:
travellerController
tripController
Travel Management Application:
An application to help create, organize, and manage trips 

Database Requirements:
Add- Add destinations and travelers to the database.
Modify - Update travel status and caretakers (from travel agency to traveler) as trips progress.
Search - Allow travelers to search for destinations based on specific parameters such as location, activities, budget, etc.
Delete - Delete destinations or traveler profiles

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
    public class Traveler
    {
        OleDbConnection myConnection;
        string nameTraveler;
        string contactDetails;
        string preferences;
        string password;
        public Traveler(string nameTraveler, string contactDetails,string preferences,string password)
        {
            this.nameTraveler = nameTraveler;
            this.contactDetails = contactDetails;
            this.preferences = preferences;
            this.password = password;
        }
        public string getName()
        {
            return this.nameTraveler;
        }
        public void saveTraveler()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();

            String query = "INSERT INTO traveler ([nameTraveler], [contactDetails], [preferences], [password]) " +
                           "VALUES (@nameTraveler, @contactDetails, @preferences, @password)";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@nameTraveler", this.nameTraveler);
            cmd.Parameters.AddWithValue("@contactDetails", this.contactDetails);
            cmd.Parameters.AddWithValue("@preferences", this.preferences);
            cmd.Parameters.AddWithValue("@password", this.password);

            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void loadTraveler(string nameSearch)
        {
            this.nameTraveler = nameSearch;
            string query = "SELECT * " +
              "FROM traveler " +
              "WHERE [name] = @name";

            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            cmd.Parameters.AddWithValue("@nameTraveler", nameSearch);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.nameTraveler = reader.GetString(reader.GetOrdinal("nameTraveler"));
                this.contactDetails = reader.GetString(reader.GetOrdinal("contactDetails"));
                this.preferences = reader.GetString(reader.GetOrdinal("preferences"));
                this.preferences = reader.GetString(reader.GetOrdinal("password"));
            }
            reader.Close();
            myConnection.Close();

        }
        public void deleteTraveler(string nameTraveler)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "DELETE FROM traveler WHERE [nameTraveler] = @nameTraveler";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@nameTraveler", nameTraveler);

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void updateTraveler()
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=lab5DB.accdb;");
            myConnection.Open();
            String query = "UPDATE traveler SET " +
              "[contactDetails] = @contactDetails, " +
              "[preferences] = @preferences, " +
              "[password] = @password" +
              "WHERE [nameTraveler] = @nameTraveler";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);

            // Add parameters with values
            cmd.Parameters.AddWithValue("@contactDetails", this.contactDetails);
            cmd.Parameters.AddWithValue("@preferences", this.preferences);
            cmd.Parameters.AddWithValue("@password", this.password);
            cmd.Parameters.AddWithValue("@nameTraveler", this.nameTraveler);

            //execute
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}