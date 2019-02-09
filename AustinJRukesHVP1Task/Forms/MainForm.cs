using AustinJRukesHVP1Task.Classes;
using AustinJRukesHVP1Task.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AustinJRukesHVP1Task
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            partsDataGridView.DataSource = Inventory.PartInventory;
            productsDataGridView.DataSource = Inventory.ProductInventory;
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(partsSearchTextbox.Text) >= 0)
                {
                    Part searchedPart = Inventory.lookupPart(Convert.ToInt32(partsSearchTextbox.Text));
                    Inventory.TempPartInventory.Add(searchedPart);
                    partsDataGridView.DataSource = Inventory.TempPartInventory;
                }
                else
                {
                    MessageBox.Show("ID must be greater than or equal to 0");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Please enter the ID of search Product");
            }
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            AddPartForm aPartForm = new AddPartForm();
            aPartForm.ShowDialog();
        }

        private void modifyPartsButton_Click(object sender, EventArgs e)
        {
            ModifyPartForm mPartForm = new ModifyPartForm();
            mPartForm.modifyPartIDText.Enabled = false;
            if (partsDataGridView.CurrentRow.DataBoundItem is InHouse) {
                mPartForm.modifyPartInhouseButton.Select();
                mPartForm.modifyPartIDText.Text = partsDataGridView.CurrentRow.Cells[0].Value.ToString();
                mPartForm.modifyPartNameText.Text = partsDataGridView.CurrentRow.Cells[1].Value.ToString();
                mPartForm.modifyPartInvAmtText.Text = partsDataGridView.CurrentRow.Cells[2].Value.ToString();
                mPartForm.modifyPartPriceText.Text = partsDataGridView.CurrentRow.Cells[3].Value.ToString();
                mPartForm.modifyPartMinText.Text = partsDataGridView.CurrentRow.Cells[4].Value.ToString();
                mPartForm.modifyPartMaxText.Text = partsDataGridView.CurrentRow.Cells[5].Value.ToString();
                mPartForm.label8.Text = "Machine ID";
                InHouse ih = (InHouse)partsDataGridView.CurrentRow.DataBoundItem;
                mPartForm.modifyPartCompanyNameOrMIDText.Text = ih.MachineID.ToString();
            }
            else
            {
                mPartForm.modifyPartOutsourcedButton.Select();
                mPartForm.modifyPartIDText.Text = partsDataGridView.CurrentRow.Cells[0].Value.ToString();
                mPartForm.modifyPartNameText.Text = partsDataGridView.CurrentRow.Cells[1].Value.ToString();
                mPartForm.modifyPartInvAmtText.Text = partsDataGridView.CurrentRow.Cells[2].Value.ToString();
                mPartForm.modifyPartPriceText.Text = partsDataGridView.CurrentRow.Cells[3].Value.ToString();
                mPartForm.modifyPartMinText.Text = partsDataGridView.CurrentRow.Cells[4].Value.ToString();
                mPartForm.modifyPartMaxText.Text = partsDataGridView.CurrentRow.Cells[5].Value.ToString();
                Outsourced os = (Outsourced)partsDataGridView.CurrentRow.DataBoundItem;
                mPartForm.modifyPartCompanyNameOrMIDText.Text = os.CompanyName;
            }

            mPartForm.ShowDialog();
            
        }

        private void deletePartsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Inventory.deletePart((Part)partsDataGridView.CurrentRow.DataBoundItem);
            }
            else
            {
                //Do Nothing - Breaks Method
            }
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(productsSearchTextbox.Text) >= 0) {
                    Product searchedProduct = Inventory.lookupProduct(Convert.ToInt32(productsSearchTextbox.Text));
                    Inventory.TempProductInventory.Add(searchedProduct);
                    productsDataGridView.DataSource = Inventory.TempProductInventory;
                }
                else
                {
                    MessageBox.Show("ID must be greater than or equal to 0");
                }
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Please enter the ID of search Product");
            }
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Inventory.currentProduct = (Product)productsDataGridView.CurrentRow.DataBoundItem;

            if (result == DialogResult.Yes)
            {
                if (Inventory.currentProduct.AssociatedPart.Count == 0)
                {
                    Inventory.deleteProduct((Product)productsDataGridView.CurrentRow.DataBoundItem);
                }
                else
                {
                    MessageBox.Show("This Product has a part associated.");
                }
            }
            else
            {
                //Do Nothing - Breaks Method
            }
        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            AddProductForm aProductForm = new AddProductForm();
            aProductForm.ShowDialog();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            Inventory.currentProduct = (Product)productsDataGridView.CurrentRow.DataBoundItem;
            ModifyProductForm mProductForm = new ModifyProductForm();
            mProductForm.modifyProductIDText.Text = productsDataGridView.CurrentRow.Cells[0].Value.ToString();
            mProductForm.modifyProductNameText.Text = productsDataGridView.CurrentRow.Cells[1].Value.ToString();
            mProductForm.modifyProductInvAmtText.Text = productsDataGridView.CurrentRow.Cells[2].Value.ToString();
            mProductForm.modifyProductPriceText.Text = productsDataGridView.CurrentRow.Cells[3].Value.ToString();
            mProductForm.modifyProductMinText.Text = productsDataGridView.CurrentRow.Cells[4].Value.ToString();
            mProductForm.modifyProductMaxText.Text = productsDataGridView.CurrentRow.Cells[5].Value.ToString();
            mProductForm.ShowDialog();

        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partsSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(partsSearchTextbox.Text)){
                Inventory.TempPartInventory.Clear();
                partsDataGridView.DataSource = Inventory.PartInventory;
            }
        }

        private void productsSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(productsSearchTextbox.Text)){
                Inventory.TempProductInventory.Clear();
                productsDataGridView.DataSource = Inventory.ProductInventory;
            }
        }
    }
}
