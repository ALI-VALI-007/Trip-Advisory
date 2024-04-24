using System;
using System.Collections.Generic;
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
            curReview = null;
        }
        public bool validReviewSave(string travelerName, string ratingStr, string comments)
        {
            int ratingInt = checkIfInt(ratingStr);
            if ( (travelerCheck(travelerName) == false) || ratingInt==-1 )
            {
                return false;
            }
            Traveler curTraveler= null;
            curTraveler.loadTraveler(travelerName);
            curReview = new Reviews(curTraveler, ratingInt, comments);
            curReview.saveReview();
            return true;
        }

        public bool validReviewLoad(string travelerName) //Basically itll check if the textbox is valid int, then check if date is empty to see if the values loaded
        {
            curReview.loadReview(travelerName);
            int rating = curReview.getRating();
            if (rating > 0)
            {
                this.curReview.loadReview(travelerName);
                return true;
            }
            return false;
        }
        public bool validReviewDelete(string travelerName) //Its gonna check if txtbx valid, then try to load it.if it can then we can delete it
        {
            bool loadBool = validReviewLoad(travelerName);
            if (loadBool) //if it did load then that means that it is a real entry and we can then delete it
            {
                this.curReview.deleteReview(travelerName);
                return true;
            }
            return false;
        }
        public bool validReviewUpdate(string travelerName, string ratingStr, string comments)
        {//Its gonna check if txtbx valid, then try to load it.if it can then we can update its
            int ratingInt= checkIfInt(ratingStr);
            if (travelerCheck(travelerName)==false && ratingInt!=0)
            {
                return false;
            }
            Traveler curTraveler = null;
            curTraveler.loadTraveler(travelerName);
            curReview = new Reviews(curTraveler, ratingInt, comments);
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
            Traveler traveler = null;
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
            List<string> result = new List<string>();
            foreach(Reviews loopReview in reviewList)
            {
                result.Add(loopReview.getString());
            }
            return result;
        }
    }
}
