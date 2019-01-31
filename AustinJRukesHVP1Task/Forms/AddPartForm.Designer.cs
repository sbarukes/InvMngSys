namespace AustinJRukesHVP1Task
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPartInhouseButton = new System.Windows.Forms.RadioButton();
            this.addPartOutsourcedButton = new System.Windows.Forms.RadioButton();
            this.addPartPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addPartIDText = new System.Windows.Forms.TextBox();
            this.addPartNameText = new System.Windows.Forms.TextBox();
            this.addPartInvAmtText = new System.Windows.Forms.TextBox();
            this.addPartPriceText = new System.Windows.Forms.TextBox();
            this.addPartMinText = new System.Windows.Forms.TextBox();
            this.addPartMaxText = new System.Windows.Forms.TextBox();
            this.addPartCompanyNameOrMachineIDText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addPartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPartInhouseButton
            // 
            this.addPartInhouseButton.AutoSize = true;
            this.addPartInhouseButton.Location = new System.Drawing.Point(3, 3);
            this.addPartInhouseButton.Name = "addPartInhouseButton";
            this.addPartInhouseButton.Size = new System.Drawing.Size(68, 17);
            this.addPartInhouseButton.TabIndex = 0;
            this.addPartInhouseButton.TabStop = true;
            this.addPartInhouseButton.Text = "In-House";
            this.addPartInhouseButton.UseVisualStyleBackColor = true;
            this.addPartInhouseButton.CheckedChanged += new System.EventHandler(this.addPartInhouseButton_CheckedChanged);
            // 
            // addPartOutsourcedButton
            // 
            this.addPartOutsourcedButton.AutoSize = true;
            this.addPartOutsourcedButton.Location = new System.Drawing.Point(115, 3);
            this.addPartOutsourcedButton.Name = "addPartOutsourcedButton";
            this.addPartOutsourcedButton.Size = new System.Drawing.Size(80, 17);
            this.addPartOutsourcedButton.TabIndex = 1;
            this.addPartOutsourcedButton.TabStop = true;
            this.addPartOutsourcedButton.Text = "Outsourced";
            this.addPartOutsourcedButton.UseVisualStyleBackColor = true;
            this.addPartOutsourcedButton.CheckedChanged += new System.EventHandler(this.addPartOutsourcedButton_CheckedChanged);
            // 
            // addPartPanel
            // 
            this.addPartPanel.Controls.Add(this.addPartInhouseButton);
            this.addPartPanel.Controls.Add(this.addPartOutsourcedButton);
            this.addPartPanel.Location = new System.Drawing.Point(163, 43);
            this.addPartPanel.Name = "addPartPanel";
            this.addPartPanel.Size = new System.Drawing.Size(243, 27);
            this.addPartPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Part";
            // 
            // addPartIDText
            // 
            this.addPartIDText.Enabled = false;
            this.addPartIDText.Location = new System.Drawing.Point(258, 135);
            this.addPartIDText.Name = "addPartIDText";
            this.addPartIDText.Size = new System.Drawing.Size(109, 20);
            this.addPartIDText.TabIndex = 4;
            // 
            // addPartNameText
            // 
            this.addPartNameText.Location = new System.Drawing.Point(258, 185);
            this.addPartNameText.Name = "addPartNameText";
            this.addPartNameText.Size = new System.Drawing.Size(109, 20);
            this.addPartNameText.TabIndex = 5;
            // 
            // addPartInvAmtText
            // 
            this.addPartInvAmtText.Location = new System.Drawing.Point(258, 234);
            this.addPartInvAmtText.Name = "addPartInvAmtText";
            this.addPartInvAmtText.Size = new System.Drawing.Size(109, 20);
            this.addPartInvAmtText.TabIndex = 6;
            // 
            // addPartPriceText
            // 
            this.addPartPriceText.Location = new System.Drawing.Point(258, 287);
            this.addPartPriceText.Name = "addPartPriceText";
            this.addPartPriceText.Size = new System.Drawing.Size(109, 20);
            this.addPartPriceText.TabIndex = 7;
            // 
            // addPartMinText
            // 
            this.addPartMinText.Location = new System.Drawing.Point(302, 342);
            this.addPartMinText.Name = "addPartMinText";
            this.addPartMinText.Size = new System.Drawing.Size(82, 20);
            this.addPartMinText.TabIndex = 8;
            // 
            // addPartMaxText
            // 
            this.addPartMaxText.Location = new System.Drawing.Point(163, 342);
            this.addPartMaxText.Name = "addPartMaxText";
            this.addPartMaxText.Size = new System.Drawing.Size(82, 20);
            this.addPartMaxText.TabIndex = 9;
            // 
            // addPartCompanyNameOrMachineIDText
            // 
            this.addPartCompanyNameOrMachineIDText.Location = new System.Drawing.Point(258, 396);
            this.addPartCompanyNameOrMachineIDText.Name = "addPartCompanyNameOrMachineIDText";
            this.addPartCompanyNameOrMachineIDText.Size = new System.Drawing.Size(109, 20);
            this.addPartCompanyNameOrMachineIDText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inventory Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price of Part:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Min:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Company Name:";
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Location = new System.Drawing.Point(240, 441);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addPartSaveButton.TabIndex = 18;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addPartSaveButton_Click);
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Location = new System.Drawing.Point(331, 441);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addPartCancelButton.TabIndex = 19;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name of Part:";
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 476);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPartCompanyNameOrMachineIDText);
            this.Controls.Add(this.addPartMaxText);
            this.Controls.Add(this.addPartMinText);
            this.Controls.Add(this.addPartPriceText);
            this.Controls.Add(this.addPartInvAmtText);
            this.Controls.Add(this.addPartNameText);
            this.Controls.Add(this.addPartIDText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPartPanel);
            this.Name = "AddPartForm";
            this.Text = "AddPartForm";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            this.addPartPanel.ResumeLayout(false);
            this.addPartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton addPartInhouseButton;
        private System.Windows.Forms.RadioButton addPartOutsourcedButton;
        private System.Windows.Forms.Panel addPartPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addPartIDText;
        private System.Windows.Forms.TextBox addPartNameText;
        private System.Windows.Forms.TextBox addPartInvAmtText;
        private System.Windows.Forms.TextBox addPartPriceText;
        private System.Windows.Forms.TextBox addPartMinText;
        private System.Windows.Forms.TextBox addPartMaxText;
        private System.Windows.Forms.TextBox addPartCompanyNameOrMachineIDText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.Label label3;
    }
}