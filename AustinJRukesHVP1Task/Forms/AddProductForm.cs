using AustinJRukesHVP1Task.Classes;
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
            addProductPartDataGrid.DataSource = Inventory.PartInventory;
            addProductRelatedPArtsDataGrid.DataSource = Product.AssociatedPart;
        }

        private void addProductDeleteRelationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Product.removeAssociatedPart(Convert.ToInt32(addProductRelatedPArtsDataGrid.CurrentRow.Cells[0].Value));
            }
            else
            {
                // Do Nothing - Break Method
            }
        }

        private void addProductAddRelationButton_Click(object sender, EventArgs e)
        {
            Product.addAssociatedPart((Part)addProductPartDataGrid.CurrentRow.DataBoundItem);
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                productToAdd = new Product
                (
                addProductNameText.Text,
                Convert.ToInt32(addProductInvAmtText.Text),
                Convert.ToDecimal(addProductPriceText.Text),
                Convert.ToInt32(addProductMinText.Text),
                Convert.ToInt32(addProductMaxText.Text)
                );
                Inventory.addProduct(productToAdd);
                this.Close();
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
            Part searchedPart = Inventory.lookupPart(Convert.ToInt32(addProductSearchText.Text));
            Inventory.TempPartInventory.Add(searchedPart);
            addProductPartDataGrid.DataSource = Inventory.TempPartInventory;
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
