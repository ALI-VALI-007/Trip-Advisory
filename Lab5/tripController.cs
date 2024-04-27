using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Windows.Forms;
/*using Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;*/

namespace Lab5
{
    public class tripController
    {
        Trip curTrip;
        public tripController()
        {//you can add stuff, i wouldnt
            curTrip = new Trip(-1,"","","","",-1.0,"","","","");
        }
        public bool validTripSave(string dateMade, string activities, string accomendations, string destination, string additionalCost, string tName, string status, string careTaker, string dateOver)
        {
            bool paramCheck = strCheck(dateMade, activities, accomendations, destination, additionalCost, tName, status, careTaker, dateOver);
            if (!paramCheck)
            {
                return false;
            }
            double additionalCostFloat = checkIfFloat(additionalCost);

            if (additionalCostFloat == -1.0 )
            {
                return false;
            }
            
            curTrip = new Trip(-1,dateMade, activities,accomendations,destination,additionalCostFloat, tName, status, careTaker, dateOver);
            curTrip.saveTrip();
            return true;
        }

        public bool validTripLoad(string tripName) //Basically itll check if the textbox is valid int, then check if date is empty to see if the values loaded
        {
            int tripID = checkIfInt(tripName);
            if (tripID != -1)
            {
                this.curTrip.loadTrip(tripID);
                string test =this.curTrip.getDestination();
                if ( !string.IsNullOrEmpty(test) )
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
        public bool validTripUpdate(string idNumber, string dateMade, string activities, string accomendations, string destination, string additionalCost, string tName, string status, string careTaker, string dateOver)
        {//Its gonna check if txtbx valid, then try to load it.if it can then we can update its
            bool paramCheck = strCheck(dateMade,activities,accomendations,destination,additionalCost,tName,status,careTaker,dateOver);
            if (!paramCheck)
            {
                return false;
            }

            int tripIdInt = checkIfInt(idNumber);
            double additionalCostFloat = checkIfFloat(additionalCost);
            if ( additionalCostFloat == -1.0 || tripIdInt == -1 || !validTripLoad(idNumber) || !destinationCheck(destination) )
            {
                //MessageBox.Show(tripIdInt.ToString());
                return false;
            }
            curTrip.setIdNumber(tripIdInt);
            curTrip.setDateMade(dateMade);
            curTrip.setActivities(activities);
            curTrip.setDestination(destination); //trigger destination validation as well (just load it)
            curTrip.setaccomedations(accomendations);
            curTrip.setAdditionalCost(additionalCostFloat);
            curTrip.settName(tName);
            curTrip.setStatus(status);
            curTrip.setCareTaker(careTaker);
            curTrip.setDateOver(dateOver);
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
        private double checkIfFloat(string floatCheck) // checks if float and has only hundredth place decimal
        {
            double number = -1.0;
            if (double.TryParse(floatCheck, out number))
            {
                if ((number * 100) % 1 == 0)
                {
                    return number;
                }
            }
            return -1;
        }
        private bool destinationCheck(string destinationName)
        {
            destinationController dc = new destinationController();
            bool loaded=dc.validDestinationLoad(destinationName);
            //string location = curDestination.getLocation();
            //MessageBox.Show(location);
            if (loaded)
            {
                return false;
            }
            return true;
        }
        public string getRecipt()
        {
            return this.curTrip.getString();
        }

        public void sendEmail(string username/*, string filePath*/)
        {
            travelerController controller = new travelerController();
            controller.validTravelerLoad(username);
            destinationController dt = new destinationController();
            string destination = curTrip.getDestination();
            dt.validDestinationLoad(destination);
       
            double finalPrice = this.curTrip.getCost() + dt.getPrice();
            string content = "Thank you for booking the trip. Your total is: $" + finalPrice;
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("componentdesignemail@gmail.com", "elue smxq alop ykbi");//feel free to use this email
            smtpClient.EnableSsl = true;

            // from, to, subject, content
            string clientEmail = controller.getEmail();
            var message = new MailMessage("componentdesignemail@gmail.com", clientEmail, "Lab 5: Reciept", content);

            //var attachment = new Attachment("reciept.xlsx", MediaTypeNames.Application.Octet);
            //message.Attachments.Add(attachment);

            smtpClient.Send(message);
        }
        /*public void makeExcel()
        {
            var excelApp = new excel.Application;
        }*/
        public List<string> findIdUser(string name) //Its gonna check if txtbx valid, then try to load it.if it can then we can delete it
        {
            List<int> ids = new List<int>();

            ids = curTrip.findIdUser(name);
            List<string> list = new List<string>();
            foreach(int x in ids)
            {
                string xStr = x.ToString();
                list.Add(xStr);
                //MessageBox.Show(xStr);
            }
            return list;
        }
        public List<string> getAll(string nameSearch)
        {
            return curTrip.loadAllTrips(nameSearch);
        }
        private bool strCheck(string x, string y, string z, string a, string b, string c, string d, string e, string f)
        {
            if (string.IsNullOrEmpty(x) || string.IsNullOrEmpty(y) || string.IsNullOrEmpty(z) || string.IsNullOrEmpty(a))
            {
                return false;
            }
            if(string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c) || string.IsNullOrEmpty(d) || string.IsNullOrEmpty (e) || string.IsNullOrEmpty(f))
            {
                return false;
            }
            return true;
        }
    }
}
