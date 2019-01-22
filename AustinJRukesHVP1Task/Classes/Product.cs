﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AustinJRukesHVP1Task.Classes
{
    class Product
    {
        private static BindingList<Part> associatedPart = new BindingList<Part>();

        public static BindingList<Part> AssociatedPart { get { return associatedPart; } set { associatedPart = value; } }

        public Product(int prID, string n, int inS, decimal price, int min, int max)
        {
            ProductID = prID;
            Name = n;
            InStock = inS;
            Price = price;
            Min = min;
            Max = max;
        }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        //methods

        public static void addAssociatedPart(Part newAssociatedPart)
        {
            AssociatedPart.Add(newAssociatedPart);
        }

        public static bool removeAssociatedPart(int associatedPartID)
        {

            foreach (Part part in AssociatedPart)
            {
                if (associatedPartID == part.PartID)
                {
                    AssociatedPart.Remove(part);
                }
                else
                {
                    continue;
                }
            }
            return true;
        }

        public static Part lookupAssociatedPart(int associatedPartID)
        {
            foreach (Part part in AssociatedPart)
            {
                if (associatedPartID == part.PartID)
                {
                    return part;
                }

            }

            return null;
        }
    }
}
