using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class destinationController
    {
        Destination curDestinaton;
        public destinationController()
        {//you can add stuff, i wouldnt
            curDestinaton = new Destination("","",-1.0,"","");
        }
        public bool validDestinationSave(string destinationName, string location, string cost, string URL, string attractions) {
            bool paramCheck = strCheck(destinationName, location, cost, URL, attractions);
            if (!paramCheck)
            {
                return false;
            }


            double costFloat = checkIfFloat(cost);
            if (costFloat == -1.0 || validDestinationLoad(destinationName))
            {
                return false;
            }
            curDestinaton = new Destination(destinationName, location, costFloat, URL, attractions);
            curDestinaton.saveDestination();
            return true;
        }
        public bool validDestinationLoad(string destinationName) //Basically itll check if the textbox is valid int, then check if date is empty to see if the values loaded
        {
            curDestinaton.loadDestination(destinationName);
            if ( !string.IsNullOrEmpty(this.curDestinaton.getLocation()) )
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
        public bool validDestinationUpdate(string destinationName, string location, string cost, string URL, string attractions)
        {//Its gonna check if txtbx valid, then try to load it.if it can then we can update its
            bool paramCheck = strCheck(destinationName,location,cost,URL,attractions);
            if (!paramCheck)
            {
                return false;
            }


            double costFloat = checkIfFloat(cost);
            if (costFloat == -1.0 || !validDestinationLoad(destinationName))
            {
                return false;
            }
            curDestinaton.setDestinationName(destinationName);
            curDestinaton.setLocation(location);
            curDestinaton.setCost(costFloat);
            curDestinaton.setURL(URL);
            curDestinaton.setAttractions(attractions);
            curDestinaton.updateDestination();
            return true;
        }
        public List<string> getDestinationList()
        {
            List<Destination> destinationList= curDestinaton.loadAllDestinations();
            List<string> result= new List<string>();
            foreach (Destination loopDestination in destinationList)
            {
                //MessageBox.Show(loopDestination.getName());
                result.Add(loopDestination.getName());
            }
            return result;
        }
        private double checkIfFloat(string floatCheck) // checks if float and has only hundredth place decimal
        {
            double number = -1.0;
            if (double.TryParse(floatCheck, out number))
            {
                if ( (number*100) % 1 == 0)
                {
                    return number;
                }
            }
            return -1;
        }
        public DataTable getDVG(string destinationName)
        {
            DataTable dt = new DataTable();
            dt = curDestinaton.loadDGV(destinationName);
            return dt;
        }
        public string getURL()
        {
            return this.curDestinaton.getURL();
        }
        public string getActivities()
        {
            return this.curDestinaton.getAttractions();
        }
        public double getPrice()
        {
            return this.curDestinaton.getCost();
        }
        public DataTable filterDVG(string price, string destination, string activities)
        {
            DataTable dt = new DataTable();
            double x = checkIfFloat(price);
            dt = curDestinaton.filterDestination(x,destination, activities);
            return dt;
        }
        private bool strCheck(string x, string y, string z, string a, string b)
        {
            if (string.IsNullOrEmpty(x) || string.IsNullOrEmpty(y) || string.IsNullOrEmpty(z) || string.IsNullOrEmpty(a))
            {
                return false;
            }
            if (string.IsNullOrEmpty(b))
            {
                return false;
            }
            return true;
        }
    }
}
