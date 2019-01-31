﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AustinJRukesHVP1Task.Classes
{
    class InHouse : Part
    {
        public InHouse(int pID, string n, int inS, decimal price, int min, int max, int mID)
            : base(pID, n, inS, price, min, max)
        {
            MachineID = mID;
        }

        public InHouse(string n, int inS, decimal price, int min, int max, int mID)
            : base(n, inS, price, min, max)
        {
            MachineID = mID;
        }

        public int MachineID { get; set; }

    }
}
