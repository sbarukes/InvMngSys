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
        public AddPartForm()
        {
            InitializeComponent();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            if (addPartInhouseButton.Checked)
            {
                Part alteredPart = new InHouse(Convert.ToInt32(addPartIDText.Text),
                    addPartNameText.Text,
                    Convert.ToInt32(addPartInvAmtText.Text),
                    Convert.ToDecimal(addPartPriceText.Text),
                    Convert.ToInt32(addPartMinText.Text),
                    Convert.ToInt32(addPartMaxText.Text),
                    Convert.ToInt32(addPartCompanyNameOrMachineIDText.Text));
                Inventory.addPart(alteredPart);
                this.Close();
            }
            else
            {
                Part alteredPart = new Outsourced(Convert.ToInt32(addPartIDText.Text),
                    addPartNameText.Text,
                    Convert.ToInt32(addPartInvAmtText.Text),
                    Convert.ToDecimal(addPartPriceText.Text),
                    Convert.ToInt32(addPartMinText.Text),
                    Convert.ToInt32(addPartMaxText.Text),
                    addPartCompanyNameOrMachineIDText.Text);
                Inventory.addPart(alteredPart);
                this.Close();
            }
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPartInhouseButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID:";
        }

        private void addPartOutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name:";
        }
    }
}
