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
            Inventory.PartInventory.Add(new InHouse(1, "New Part", 100, 20.10m, 10, 15, 135));
            Inventory.PartInventory.Add(new InHouse(2, "New Part2", 100, 20.99m, 10, 15, 135));
            Inventory.PartInventory.Add(new Outsourced(3, "New Part3", 100, 25.99m, 15, 50, "New Water Computing"));
            Inventory.ProductInventory.Add(new Product(1, "New Product", 10, 20.00m, 1, 5));
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            Part searchedPart = Inventory.lookupPart(Convert.ToInt32(partsSearchTextbox.Text));
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
                mPartForm.modifyPartOutsourcedButton.Enabled = false;
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
                mPartForm.modifyPartInhouseButton.Enabled = false;
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
            Inventory.deletePart((Part)partsDataGridView.CurrentRow.DataBoundItem);
        }

    }
}