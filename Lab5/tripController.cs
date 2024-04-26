using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
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
                if( string.IsNullOrEmpty(this.curTrip.getDateMade()) )
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
            int tripIdInt = checkIfInt(idNumber);
            double additionalCostFloat = checkIfFloat(additionalCost);
            if ( additionalCostFloat == -1.0 || tripIdInt == -1 || !validTripLoad(idNumber) || !destinationCheck(destination)==false )
            {
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
            Destination destination = null;
            destination.loadDestination(destinationName);
            string location = destination.getLocation();
            if ( string.IsNullOrEmpty(location) )
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
            controller.getEmail();
            string content = "Thank you for booking the trip. Your total is: " +this.curTrip.getCost();
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("componentdesignemail@gmail.com", "elue smxq alop ykbi");//feel free to use this email
            smtpClient.EnableSsl = true;

            // from, to, subject, content
            var message = new MailMessage("componentdesignemail@gmail.com", "alisvali007@gmail.com", "Lab 5: Reciept", content);

            //var attachment = new Attachment("reciept.xlsx", MediaTypeNames.Application.Octet);
            //message.Attachments.Add(attachment);

            smtpClient.Send(message);
        }
        /*public void makeExcel()
        {
            var excelApp = new excel.Application;
        }*/
    }
}
