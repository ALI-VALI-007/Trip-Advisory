using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public class travelerController
    {
        Traveler curTraveler;
        public travelerController()
        {//you can add stuff, i wouldnt
            curTraveler = new Traveler("","","","");
        }
        public bool validTravelerSave(string nameTraveler, string contactDetails, string preferences, string password)
        {
            if (validTravelerLoad(nameTraveler) || checkIfInt(password)!=-1 )
            {
                //MessageBox.Show(checkIfInt(password).ToString());
                //MessageBox.Show(validTravelerLoad(nameTraveler).ToString());
                return false;
            }
            curTraveler = new Traveler(nameTraveler, contactDetails, preferences, password);
            curTraveler.saveTraveler();
            return true;
        }
        public bool validTravelerLoad(string nameTraveler) //Basically itll check if the textbox is valid int, then check if date is empty to see if the values loaded
        {
            curTraveler.loadTraveler(nameTraveler);
            //MessageBox.Show(curTraveler.getPassword());
            string password=this.curTraveler.getPassword();
            if ( string.IsNullOrEmpty(password) )
            {
                return false;
            }
            return true;
        }
        public bool validTravelerDelete(string nameTraveler) //Its gonna check if txtbx valid, then try to load it.if it can then we can delete it
        {
            bool loadBool = validTravelerLoad(nameTraveler);
            if (loadBool) //if it did load then that means that it is a real entry and we can then delete it
            {
                this.curTraveler.deleteTraveler(nameTraveler);
                return true;
            }
            return false;
        }
        public bool validTravelerUpdate(string nameTraveler, string contactDetails, string preferences, string password)
        {//Its gonna check if txtbx valid, then try to load it.if it can then we can update its
            if ( !validTravelerLoad(nameTraveler) || checkIfInt(password) != -1)
            {
                return false;
            }
            curTraveler.setPreferences(preferences);
            curTraveler.setPassword(password);
            curTraveler.setContactDetails(contactDetails);
            curTraveler.updateTraveler();
            return true;
        }
        private int checkIfInt(string intCheck)
        {
            int number = -1;
            if (int.TryParse(intCheck, out number))
            {
                return number;
            }
            return -1;
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
        public bool passwordCheck(string inputPassword)
        {
            if(inputPassword == curTraveler.getPassword())
            {
                return true;
            }
            return false;
        }
        public List<string> getTravelerList()
        {
            List<Traveler> travelerList = curTraveler.loadAllTravelers();
            List<string> result = new List<string>();
            foreach (Traveler loopTraveler in travelerList)
            {
                result.Add(loopTraveler.getString());
            }
            return result;
        }
        public string getAccomedations()
        {
            return this.curTraveler.getPreferences();
        }
        public string getEmail()
        {
            return this.curTraveler.getEmail();
        }
    }
}
