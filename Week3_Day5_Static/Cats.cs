using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day5_Static
{
    class Cats
    {
        protected int catCount;
        public int CatCount
        { get { return this.catCount; }
         set { this.catCount = value; }
        }

        public Cats ()
        {

        }
        
        public void WarCry()
        {
            Console.WriteLine("We are an army of " + catCount + " cats!");
        }
    }
}
