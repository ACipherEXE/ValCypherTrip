/*Chirstopher J Negron
 * 10/6/2020
 * 
 * I have been playing Valorant for a while and I wanted to make something fast for the agent I play
 * named Cypher. Cypher is a control character that can lock down areas and one of his tools is the tripwire, 
 * its used to give informacion to the team about where others are entering. 
 * The point of this project is to do the same thing.
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValCypherTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            Tripwire test = new Tripwire();
            String tripName = "Trip 1"; //Enter the name of the trip
            String tripOutput = "set";// enter the output
            //Types of output
            /*
             * alarm: Tripwire activated
             * set: Trip has been set
             * error: something went worng
             * 
             * But if nothing:
             * it will return null
             */
            Console.WriteLine(test.soundTrigger(tripOutput, tripName));
        }
    }
}
