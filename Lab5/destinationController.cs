using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class destinationController
    {
        Destination curDestinaton;
        public destinationController()
        {//you can add stuff, i wouldnt

        }
        public bool validDestinationSave(string destinationName, string location, string cost) { 
            float costFloat = checkIfFloat(cost);
            if (costFloat == -1.0f || validDestinationLoad(destinationName))
            {
                return false;
            }
            curDestinaton = new Destination(destinationName, location, costFloat);
            curDestinaton.saveDestination();
            return true;
        }

        public bool validDestinationLoad(string destinationName) //Basically itll check if the textbox is valid int, then check if date is empty to see if the values loaded
        {
            curDestinaton.loadDestination(destinationName);
            if (this.curDestinaton.getLocation() != "")
            {
                return true;
            }
            return false;

        }
        public bool validDestinationDelete(string destinationName) //Its gonna check if txtbx valid, then try to load it.if it can then we can delete it
        {
            bool loadBool = validDestinationLoad(destinationName);
            if (loadBool) //if it did load then that means that it is a real entry and we can then delete it
            {
                this.curDestinaton.deleteDestination(destinationName);
                return true;
            }
            return false;
        }
        public bool validDestinationUpdate(string destinationName, string location, string cost)
        {//Its gonna check if txtbx valid, then try to load it.if it can then we can update its
            float costFloat = checkIfFloat(cost);
            if (costFloat == -1.0f || validDestinationLoad(destinationName))
            {
                return false;
            }
            curDestinaton.setDestinationName(destinationName);
            curDestinaton.setLocation(location);
            curDestinaton.setCost(costFloat);
            curDestinaton.updateDestination();
            return true;
        }
        private float checkIfFloat(string floatCheck) // checks if float and has only hundredth place decimal
        {
            float number = -1.0f;
            if (float.TryParse(floatCheck, out number))
            {
                if (number % 0.01f == 0)
                {
                    return number;
                }
            }
            return number;
        }
    }
}
