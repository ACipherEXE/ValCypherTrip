using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ValCypherTrip
{
    class Tripwire
    {
        public String soundTrigger(String input, String tripNumber)
        {

            if ("alarm" == input || "Alarm" == input) //Tripwire activated
            {
                Console.WriteLine("Alarmed Triggered ");
                int n = 10;
                for (int i = 1; i < n; i++)
                    Console.Beep();
     
                return "Message From: " + tripNumber;
            }
            if ("set" == input || "Set" == input) //Tripwire Set
            {
                Console.WriteLine("Alarm Set");
                int n = 2;
                for (int i = 1; i < n; i++)
                    Console.Beep();

                return "Message From: " + tripNumber;
            }
            if ("error" == input || "Error" == input) //Something went worng
            {
                Console.WriteLine("Alarm Error");
                int n = 5;
                for (int i = 1; i < n; i++)
                    Console.Beep();

                return "Message From: " + tripNumber;
            }
            else //If all fails
            {
                return null;
            }
            
            
        }
    }
}
