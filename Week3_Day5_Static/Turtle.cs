using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day5_Static
{
    class Turtle
    {
        ///// <summary>
        /////  this static variable belongs to the CLASS
        /////  and is SHARED among ALL instances
        /////  
        ///// // we can use variable without creating an instance first
        ///// 
        ///// we can use METHOD without creating any instances
        ///// </summary>
        ///// 

        static int turtleCount;

        public Turtle()
        {
            turtleCount++;
        }

        public static void WarCry()
        {
            Console.WriteLine("We are an army of " + " turtles!");
        }
    }
}
