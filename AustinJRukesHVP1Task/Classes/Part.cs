using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AustinJRukesHVP1Task.Classes
{

    abstract class Part
    {
        static int counter = -1;

        public Part(int pID, string n, int inS, decimal price, int min, int max)
        {
            PartID = pID;
            Name = n;
            InStock = inS;
            Price = price;
            Min = min;
            Max = max;
        }

        public Part(string n, int inS, decimal price, int min, int max)
        {
            PartID = Interlocked.Increment(ref counter);
            Name = n;
            InStock = inS;
            Price = price;
            Min = min;
            Max = max;
        }

        //Add Constructor Overide

        public int PartID { get; set; }

        public string Name { get; set; }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }
    }
}
