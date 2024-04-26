using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class reviewsController
    {
        Reviews curReview;
        public reviewsController()
        {//you can add stuff, i wouldnt
            Traveler traveler = new Traveler("", "", "", "");
            curReview = new Reviews(-1,traveler,-1,"","");
        }
        public bool validReviewSave(string travelerName, string ratingStr, string comments, string dName)
        {
            int ratingInt = checkIfInt(ratingStr);

            if ( (travelerCheck(travelerName) == false) || ratingInt==-1 )
            {
                return false;
            }
            Traveler traveler = new Traveler("", "", "", "");
            traveler.loadTraveler(travelerName);
            curReview.setRating(ratingInt);
            curReview.setDName(dName);
            curReview.setTraveler(traveler);
            curReview.setComments(comments);
            curReview.saveReview();
            return true;
        }
        public bool validReviewLoad(string name) //Basically itll check if the textbox is valid int, then check if date is empty to see if the values loaded
        {
            this.curReview.loadReview(name);
            int rating = curReview.getRating();
            if (rating > 0)
            {
                return true;
            }
            return false;
        }
        public bool validReviewLoadId(string id) //Basically itll check if the textbox is valid int, then check if date is empty to see if the values loaded
        {
            int idInt = checkIfInt(id);
            this.curReview.loadReviewId(idInt);
            int rating = curReview.getRating();
            if (rating > 0)
            {
                return true;
            }
            return false;
        }
        public bool validReviewDelete(string id) //Its gonna check if txtbx valid, then try to load it.if it can then we can delete it
        {
            int idInt = checkIfInt(id);
            bool loadBool = validReviewLoadId(id);
            if ( loadBool ) //if it did load then that means that it is a real entry and we can then delete it
            {
                this.curReview.deleteReview(idInt);
                return true;
            }
            return false;
        }
        public bool validReviewUpdate(string id,string travelerName, string ratingStr, string comments, string dName)
        {//Its gonna check if txtbx valid, then try to load it.if it can then we can update its
            int ratingInt= checkIfInt(ratingStr);
            int idInt = checkIfInt(id);
            if (travelerCheck(travelerName)==false && ratingInt!=0)
            {
                return false;
            }
            Traveler curTraveler = null;
            curTraveler.loadTraveler(travelerName);
            curReview.setRating(ratingInt);
            curReview.setDName(dName);
            curReview.setTraveler(curTraveler);
            curReview.setComments(comments);
            curReview.setId(idInt);
            curReview.updateReview();
            return true;
        }
        private int checkIfInt(string intCheck)
        {
            int number = -1;
            if (int.TryParse(intCheck, out number) && number>=1 && number >=5)
            {
                return number;
            }
            return number;
        }
        private bool travelerCheck(string travelerName)
        {
            Traveler traveler = new Traveler("","","","");
            traveler.loadTraveler(travelerName);
            string  preferences = traveler.getPreferences();
            if (preferences == "")
            {
                return false;
            }
            return true;
        }
        public List<string> getReviewsList()
        {
            List<Reviews> reviewList= curReview.loadAllReviews();
            List<int> result = new List<int>();
            foreach(Reviews loopReview in reviewList)
            {
                result.Add(loopReview.getId());
            }
            List<string> strings = new List<string>();
            foreach(int x in result)
            {
                strings.Add( x.ToString() );
            }
            return strings;
        }
        public DataTable getDVG(string destinationName)
        {
            DataTable dt = new DataTable();
            dt = curReview.loadDGV(destinationName);
            return dt;
        }
    }
}
