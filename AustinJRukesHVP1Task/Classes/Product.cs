using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AustinJRukesHVP1Task.Classes
{
    class Product
    {
        static int counter = -1;

        private BindingList<Part> associatedPart = new BindingList<Part>();

        public BindingList<Part> AssociatedPart { get { return associatedPart; } set { associatedPart = value; } }  //Use for error checking

        public Product(int prID, string n, int inS, decimal price, int min, int max)
        {
            AssociatedPart = new BindingList<Part>();
            ProductID = prID;
            Name = n;
            InStock = inS;
            Price = price;
            Min = min;
            Max = max;
        }

        public Product(string n, int inS, decimal price, int min, int max)
        {
            AssociatedPart = new BindingList<Part>();
            ProductID = Interlocked.Increment(ref counter);
            Name = n;
            InStock = inS;
            Price = price;
            Min = min;
            Max = max;
        }

        //Add Constructor Overide

        public int ProductID { get; set; }

        public string Name { get; set; }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        //methods

        public void addAssociatedPart(Part newAssociatedPart)
        {
            AssociatedPart.Add(newAssociatedPart);
        }

        public bool removeAssociatedPart(int associatedPartID)
        {
            try
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
            }
            catch (Exception ex)
            {

            }
            return true;
        }

        public Part lookupAssociatedPart(int associatedPartID)
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
