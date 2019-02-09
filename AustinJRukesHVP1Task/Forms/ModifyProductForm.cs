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
    public partial class ModifyProductForm : Form
    {
        Product productToModify;

        public ModifyProductForm()
        {
            InitializeComponent();
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            modifyProductPartDataGrid.DataSource = Inventory.PartInventory;
            modifyProductRelatedPArtsDataGrid.DataSource = Inventory.currentProduct.AssociatedPart;
        }

        private void modifyProductAddRelationButton_Click(object sender, EventArgs e)
        {
            Inventory.currentProduct.addAssociatedPart((Part)modifyProductPartDataGrid.CurrentRow.DataBoundItem);
        }

        private void modifyProductDeleteRelationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Inventory.currentProduct.removeAssociatedPart(Convert.ToInt32(modifyProductRelatedPArtsDataGrid.CurrentRow.Cells[0].Value));
            }
            else
            {
                // Do Nothing - Break Method
            }
        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(modifyProductMinText.Text) < Convert.ToInt32(modifyProductMaxText.Text)) && (Convert.ToInt32(modifyProductMinText.Text) < Convert.ToInt32(modifyProductInvAmtText.Text)) && (Convert.ToInt32(modifyProductInvAmtText.Text) <= Convert.ToInt32(modifyProductMaxText.Text)))
                {
                    Inventory.currentProduct.ProductID = Convert.ToInt32(modifyProductIDText.Text);
                    Inventory.currentProduct.Name = modifyProductNameText.Text;
                    Inventory.currentProduct.InStock = Convert.ToInt32(modifyProductInvAmtText.Text);
                    Inventory.currentProduct.Price = Convert.ToDecimal(modifyProductPriceText.Text);
                    Inventory.currentProduct.Min = Convert.ToInt32(modifyProductMinText.Text);
                    Inventory.currentProduct.Max = Convert.ToInt32(modifyProductMaxText.Text);
                    Inventory.updateProduct(Inventory.currentProduct, Inventory.currentProduct.ProductID);
                    this.Close();
                }
                else
                {
                    Exception exx = new Exception("Min must be less than Max and Inventory Amount must be in between the two");
                    MessageBox.Show(exx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Make sure the following fields contain the proper values:\n" +
                    "Name: Alphanumeric\n" +
                    "Inventory Amount: Number \n" +
                    "Price: Decimal\n" +
                    "Min: Number\n" +
                    "Max: Number");
            }
        }

        private void modifyProductPartSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(modifyProductSearchText.Text) >= 0)
                {
                    Part searchedPart = Inventory.lookupPart(Convert.ToInt32(modifyProductSearchText.Text));
                    Inventory.TempPartInventory.Add(searchedPart);
                    modifyProductPartDataGrid.DataSource = Inventory.TempPartInventory;
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

        private void modifyProductSearchText_TextChanged(object sender, EventArgs e)
        {
            Inventory.TempPartInventory.Clear();
            modifyProductPartDataGrid.DataSource = Inventory.PartInventory;
        }
    }
}
