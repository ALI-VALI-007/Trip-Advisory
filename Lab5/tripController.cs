using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class tripController
    {
        Trip curTrip;
        public tripController()
        {//you can add stuff, i wouldnt

        }
        public bool validTripSave(string idNumber, string dateMade, string activities, string accomendations, string destination, string additionalCost)
        {
            int tripIdInt = checkIfInt(idNumber);
            float additionalCostFloat = checkIfFloat(additionalCost);
            if (additionalCostFloat == -1.0f || tripIdInt == -1 || (validTripLoad(idNumber) == false) )
            {
                return false;
            }
            curTrip = new Trip(tripIdInt,dateMade, activities,accomendations,destination,additionalCostFloat);
            curTrip.saveTrip();
            return true;
        }

        public bool validTripLoad(string tripName) //Basically itll check if the textbox is valid int, then check if date is empty to see if the values loaded
        {
            int tripID = checkIfInt(tripName);
            if (tripID != -1)
            {
                this.curTrip.loadTrip(tripID);
                if(this.curTrip.getDateMade() != "")
                {
                    return true;
                }
            }
            return false;
        }
        public bool validTripDelete(string tripName) //Its gonna check if txtbx valid, then try to load it.if it can then we can delete it
        {
            int tripID = checkIfInt(tripName);
            bool loadBool = validTripLoad(tripName);
            if (loadBool) //if it did load then that means that it is a real entry and we can then delete it
            {
                this.curTrip.deleteTrip(tripID);
                return true;
            }
            return false;
        }
        public bool validTripUpdate(string idNumber, string dateMade, string activities, string accomendations, string destination, string additionalCost)
        {//Its gonna check if txtbx valid, then try to load it.if it can then we can update its
            int tripIdInt = checkIfInt(idNumber);
            float additionalCostFloat = checkIfFloat(additionalCost);
            if ( additionalCostFloat == -1.0f || tripIdInt == -1 || validTripLoad(idNumber) || destinationCheck(destination)==false )
            {
                return false;
            }
            curTrip.setIdNumber(tripIdInt);
            curTrip.setDateMade(dateMade);
            curTrip.setActivities(activities);
            curTrip.setDestination(destination); //trigger destination validation as well (just load it)
            curTrip.setaccomedations(accomendations);
            curTrip.setAdditionalCost(additionalCostFloat);
            curTrip.updateTrip();
            return true;
        }
        private int checkIfInt(string intCheck)
        {
            int number = -1;
            if (int.TryParse(intCheck, out number)){
                return number;
            }
            return number;
        }
        private float checkIfFloat(string floatCheck) // checks if float and has only hundredth place decimal
        {
            float number = -1.0f;
            if (float.TryParse(floatCheck, out number))
            {
                if(number % 0.01f == 0){
                    return number;
                }
            }
            return number;
        }
        private bool destinationCheck(string destinationName)
        {
            Destination destination = null;
            destination.loadDestination(destinationName);
            string location = destination.getLocation();
            if (location == "")
            {
                return false;
            }
            return true;
        }
    }
}
