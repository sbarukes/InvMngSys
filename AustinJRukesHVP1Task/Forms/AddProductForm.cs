﻿using AustinJRukesHVP1Task.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AustinJRukesHVP1Task.Forms
{
    public partial class AddProductForm : Form
    {
        Product productToAdd;

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            Inventory.currentProduct = new Product("", 0, 0.1m, 0, 1);
            addProductPartDataGrid.DataSource = Inventory.PartInventory;
            addProductRelatedPArtsDataGrid.DataSource = Inventory.currentProduct.AssociatedPart;
        }

        private void addProductDeleteRelationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Inventory.currentProduct.removeAssociatedPart(Convert.ToInt32(addProductRelatedPArtsDataGrid.CurrentRow.Cells[0].Value));
            }
            else
            {
                // Do Nothing - Break Method
            }
        }

        private void addProductAddRelationButton_Click(object sender, EventArgs e)
        {
            Inventory.currentProduct.addAssociatedPart((Part)addProductPartDataGrid.CurrentRow.DataBoundItem);
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(addProductMinText.Text) < Convert.ToInt32(addProductMaxText.Text)) && (Convert.ToInt32(addProductMinText.Text) < Convert.ToInt32(addProductInvAmtText.Text)) && (Convert.ToInt32(addProductInvAmtText.Text) <= Convert.ToInt32(addProductMaxText.Text))) {

                    Inventory.currentProduct.Name = addProductNameText.Text;
                    Inventory.currentProduct.InStock = Convert.ToInt32(addProductInvAmtText.Text);
                    Inventory.currentProduct.Price = Convert.ToDecimal(addProductPriceText.Text);
                    Inventory.currentProduct.Min = Convert.ToInt32(addProductMinText.Text);
                    Inventory.currentProduct.Max = Convert.ToInt32(addProductMaxText.Text);
                    Inventory.addProduct(Inventory.currentProduct);
                    this.Close();
                }
                else
                {
                    Exception exx = new Exception("Min must be less than Max and Inventory Amount must be in between the two");
                    MessageBox.Show(exx.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Make sure the following fields contain the proper values:\n" +
                    "Name: Alphanumeric\n" +
                    "Inventory Amount: Number \n" +
                    "Price: Decimal\n" +
                    "Min: Number\n" +
                    "Max: Number");
            }
        }

        private void addProductPartSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(addProductSearchText.Text) >= 0)
                {
                    Part searchedPart = Inventory.lookupPart(Convert.ToInt32(addProductSearchText.Text));
                    Inventory.TempPartInventory.Add(searchedPart);
                    addProductPartDataGrid.DataSource = Inventory.TempPartInventory;
                }
                else
                {
                    MessageBox.Show("ID must be greater than or equal to 0");
                }
            }

            catch (FormatException fe)
            {
                MessageBox.Show("Please enter ID of Part to search.");
            }
        }

        private void addProductSearchText_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(addProductSearchText.Text))
            {
                Inventory.TempPartInventory.Clear();
                addProductPartDataGrid.DataSource = Inventory.PartInventory;
            }
        }
    }
}
