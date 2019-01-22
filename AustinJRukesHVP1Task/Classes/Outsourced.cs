using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AustinJRukesHVP1Task.Classes
{
    class Outsourced : Part
    {
        public Outsourced(int pID, string n, int inS, decimal price, int min, int max, string cName)
            : base(pID, n, inS, price, min, max)
        {
           CompanyName = cName;
        }

        public string CompanyName { get; set; }
    }
}
