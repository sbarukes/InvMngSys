using AustinJRukesHVP1Task.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AustinJRukesHVP1Task
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Inventory.PartInventory.Add(new InHouse("New Part", 100, 20.10m, 10, 15, 135));
            Inventory.PartInventory.Add(new InHouse("New Part2", 100, 20.99m, 10, 15, 135));
            Inventory.PartInventory.Add(new Outsourced("New Part3", 100, 25.99m, 15, 50, "New Water Computing"));
            Inventory.ProductInventory.Add(new Product("New Product", 10, 20.00m, 1, 5));
            Application.Run(new MainForm());
        }
    }
}
