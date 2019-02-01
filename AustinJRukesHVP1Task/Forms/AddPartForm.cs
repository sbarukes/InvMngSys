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

namespace AustinJRukesHVP1Task
{
    public partial class AddPartForm : Form
    {
        Part addPart;

        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {
            checkRButton();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (addPartInhouseButton.Checked)
                {
                    addPart = new InHouse(addPartNameText.Text,
                        Convert.ToInt32(addPartInvAmtText.Text),
                        Convert.ToDecimal(addPartPriceText.Text),
                        Convert.ToInt32(addPartMinText.Text),
                        Convert.ToInt32(addPartMaxText.Text),
                        Convert.ToInt32(addPartCompanyNameOrMachineIDText.Text));
                    Inventory.addPart(addPart);
                    this.Close();
                }
                else
                {
                    addPart = new Outsourced(addPartNameText.Text,
                        Convert.ToInt32(addPartInvAmtText.Text),
                        Convert.ToDecimal(addPartPriceText.Text),
                        Convert.ToInt32(addPartMinText.Text),
                        Convert.ToInt32(addPartMaxText.Text),
                        addPartCompanyNameOrMachineIDText.Text);
                    Inventory.addPart(addPart);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Make sure the following fields contain the proper values:\n" +
                    "Name: Alphanumeric\n" +
                    "Inventory Amount: Number \n" +
                    "Price: Decimal\n" +
                    "Min: Number\n" +
                    "Max: Number\n" +
                    "Machine ID: Number\n" +
                    "Company Name: Alphanumeric");
            }
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkRButton()
        {
            if (addPartInhouseButton.Checked)
            {
                label8.Text = "MachineID:";
            }
            else
            {
                label8.Text = "Company Name:";
            }
        }

        private void addPartInhouseButton_CheckedChanged(object sender, EventArgs e)
        {
            checkRButton();
        }

        private void addPartOutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            checkRButton();
        }

    }
}
