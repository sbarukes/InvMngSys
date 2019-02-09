using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AustinJRukesHVP1Task.Classes
{
    class Inventory
    {
        private static BindingList<Part> partInventory = new BindingList<Part>();
        private static BindingList<Part> tempPartInventory = new BindingList<Part>();

        public static BindingList<Part> PartInventory { get { return partInventory; } set { partInventory = value; } }
        public static BindingList<Part> TempPartInventory { get { return tempPartInventory; } set { tempPartInventory = value; } }

        private static BindingList<Product> productInventory = new BindingList<Product>();
        private static BindingList<Product> tempProductInventory = new BindingList<Product>();

        public static BindingList<Product> ProductInventory { get { return productInventory; } set { productInventory = value; } }
        public static BindingList<Product> TempProductInventory { get { return tempProductInventory; } set { tempProductInventory = value; } }

        public static Product currentProduct;

        // Part Methods
        public static void addPart(Part part)
        {
            PartInventory.Add(part);
        }

        public static void deletePart(Part part)
        {
            PartInventory.Remove(part);
        }

        public static bool updatePart(Part part, int partID)
        {
            PartInventory.RemoveAt(partID); //RemoveAt()
            PartInventory.Insert(partID, part);
            return true;
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in PartInventory)
            {
                if (partID == part.PartID)
                {
                    return part;
                }

            }

            return null;
        }

        // Product Methods

        public static void addProduct(Product product)
        {
            ProductInventory.Add(product);
        }

        public static void deleteProduct(Product product)
        {
            ProductInventory.Remove(product);
        }

        public static bool updateProduct(Product product, int productID)
        {
            ProductInventory.RemoveAt(productID);
            ProductInventory.Insert(productID, product);
            return true;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in ProductInventory)
            {
                if (productID == product.ProductID)
                {
                    return product;
                }

            }

            return null;
        }
    }
}

