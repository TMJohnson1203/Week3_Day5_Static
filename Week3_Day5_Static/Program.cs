using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day5_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cats> catArmy = new List<Cats>();
            List<Turtle> turtleArray = new List<Turtle>();

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                if(rand.NextDouble() >+ 0.5)
                {
                    catArmy.Add(new Cats());
                }
                else
                {
                    turtleArray.Add(new Turtle());
                }
            }

            int totalCats = catArmy.Count;

            foreach(Cats cat in catArmy)
            {
                cat.CatCount = totalCats;
            }

            catArmy[0].WarCry();

            Turtle.WarCry();

        }
    }
}
