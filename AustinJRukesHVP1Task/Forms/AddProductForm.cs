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
            Product.removeAssociatedPart(Convert.ToInt32(addProductRelatedPArtsDataGrid.CurrentRow.Cells[0].Value));
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
            Product productToAdd = new Product
                (
                Convert.ToInt32(addProductIDText.Text),
                addProductNameText.Text,
                Convert.ToInt32(addProductInvAmtText.Text),
                Convert.ToDecimal(addProductPriceText.Text),
                Convert.ToInt32(addProductMinText.Text),
                Convert.ToInt32(addProductMaxText.Text)
                );
            Inventory.addProduct(productToAdd);
            this.Close();
        }

        private void addProductPartSearchButton_Click(object sender, EventArgs e)
        {
            Part searchedPart = Inventory.lookupPart(Convert.ToInt32(addProductSearchText.Text));
        }
    }
}
