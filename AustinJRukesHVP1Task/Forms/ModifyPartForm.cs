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
    public partial class ModifyPartForm : Form
    {
        public ModifyPartForm()
        {
            InitializeComponent();
        }


        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

        }

        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {
            if (modifyPartInhouseButton.Checked)
            {
                Part alteredPart = new InHouse(Convert.ToInt32(modifyPartIDText.Text),
                    modifyPartNameText.Text,
                    Convert.ToInt32(modifyPartInvAmtText.Text),
                    Convert.ToDecimal(modifyPartPriceText.Text),
                    Convert.ToInt32(modifyPartMinText.Text),
                    Convert.ToInt32(modifyPartMaxText.Text),
                    Convert.ToInt32(modifyPartCompanyNameOrMIDText.Text));
                Inventory.updatePart(alteredPart, alteredPart.PartID);
                this.Close();
            }
            else
            {
                Part alteredPart = new Outsourced(Convert.ToInt32(modifyPartIDText.Text),
                    modifyPartNameText.Text,
                    Convert.ToInt32(modifyPartInvAmtText.Text),
                    Convert.ToDecimal(modifyPartPriceText.Text),
                    Convert.ToInt32(modifyPartMinText.Text),
                    Convert.ToInt32(modifyPartMaxText.Text),
                    modifyPartCompanyNameOrMIDText.Text);
                Inventory.updatePart(alteredPart, alteredPart.PartID);
                this.Close();
            }
        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyPartOutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name:";
        }

        private void modifyPartInhouseButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID:";
        }
    }
}
