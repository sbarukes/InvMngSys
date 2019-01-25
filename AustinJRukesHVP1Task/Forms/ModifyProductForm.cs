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
    public partial class ModifyProductForm : Form
    {
        public ModifyProductForm()
        {
            InitializeComponent();
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            modifyProductPartDataGrid.DataSource = Inventory.PartInventory;
            modifyProductRelatedPArtsDataGrid.DataSource = Product.AssociatedPart;
        }

        private void modifyProductPartSearchButton_Click(object sender, EventArgs e)
        {
            Part searchedPart = Inventory.lookupPart(Convert.ToInt32(modifyProductSearchText.Text));
        }

        private void modifyProductAddRelationButton_Click(object sender, EventArgs e)
        {
            Product.addAssociatedPart((Part)modifyProductPartDataGrid.CurrentRow.DataBoundItem);
        }

        private void modifyProductDeleteRelationButton_Click(object sender, EventArgs e)
        {
            Product.removeAssociatedPart(Convert.ToInt32(modifyProductRelatedPArtsDataGrid.CurrentRow.Cells[0].Value));
        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            Product productToUpdate = new Product
                (
                Convert.ToInt32(modifyProductIDText.Text),
                modifyProductNameText.Text,
                Convert.ToInt32(modifyProductInvAmtText.Text),
                Convert.ToDecimal(modifyProductPriceText.Text),
                Convert.ToInt32(modifyProductMinText.Text),
                Convert.ToInt32(modifyProductMaxText.Text)
                );
            Inventory.updateProduct(productToUpdate, productToUpdate.ProductID);
            this.Close();
        }
    }
}
