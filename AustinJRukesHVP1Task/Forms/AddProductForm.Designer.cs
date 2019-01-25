namespace AustinJRukesHVP1Task.Forms
{
    partial class AddProductForm
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
            this.addProductIDText = new System.Windows.Forms.TextBox();
            this.addProductNameText = new System.Windows.Forms.TextBox();
            this.addProductInvAmtText = new System.Windows.Forms.TextBox();
            this.addProductPriceText = new System.Windows.Forms.TextBox();
            this.addProductMaxText = new System.Windows.Forms.TextBox();
            this.addProductMinText = new System.Windows.Forms.TextBox();
            this.addProductSearchText = new System.Windows.Forms.TextBox();
            this.addProductPartDataGrid = new System.Windows.Forms.DataGridView();
            this.addProductRelatedPArtsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addProductPartSearchButton = new System.Windows.Forms.Button();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            this.addProductCancelButton = new System.Windows.Forms.Button();
            this.addProductDeleteRelationButton = new System.Windows.Forms.Button();
            this.addProductAddRelationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addProductPartDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductRelatedPArtsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductIDText
            // 
            this.addProductIDText.Enabled = false;
            this.addProductIDText.Location = new System.Drawing.Point(137, 104);
            this.addProductIDText.Name = "addProductIDText";
            this.addProductIDText.Size = new System.Drawing.Size(100, 20);
            this.addProductIDText.TabIndex = 0;
            // 
            // addProductNameText
            // 
            this.addProductNameText.Location = new System.Drawing.Point(137, 148);
            this.addProductNameText.Name = "addProductNameText";
            this.addProductNameText.Size = new System.Drawing.Size(100, 20);
            this.addProductNameText.TabIndex = 1;
            // 
            // addProductInvAmtText
            // 
            this.addProductInvAmtText.Location = new System.Drawing.Point(137, 196);
            this.addProductInvAmtText.Name = "addProductInvAmtText";
            this.addProductInvAmtText.Size = new System.Drawing.Size(59, 20);
            this.addProductInvAmtText.TabIndex = 2;
            // 
            // addProductPriceText
            // 
            this.addProductPriceText.Location = new System.Drawing.Point(137, 241);
            this.addProductPriceText.Name = "addProductPriceText";
            this.addProductPriceText.Size = new System.Drawing.Size(59, 20);
            this.addProductPriceText.TabIndex = 3;
            // 
            // addProductMaxText
            // 
            this.addProductMaxText.Location = new System.Drawing.Point(137, 297);
            this.addProductMaxText.Name = "addProductMaxText";
            this.addProductMaxText.Size = new System.Drawing.Size(59, 20);
            this.addProductMaxText.TabIndex = 4;
            // 
            // addProductMinText
            // 
            this.addProductMinText.Location = new System.Drawing.Point(259, 297);
            this.addProductMinText.Name = "addProductMinText";
            this.addProductMinText.Size = new System.Drawing.Size(59, 20);
            this.addProductMinText.TabIndex = 5;
            // 
            // addProductSearchText
            // 
            this.addProductSearchText.Location = new System.Drawing.Point(500, 49);
            this.addProductSearchText.Name = "addProductSearchText";
            this.addProductSearchText.Size = new System.Drawing.Size(183, 20);
            this.addProductSearchText.TabIndex = 6;
            // 
            // addProductPartDataGrid
            // 
            this.addProductPartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductPartDataGrid.Location = new System.Drawing.Point(388, 114);
            this.addProductPartDataGrid.Name = "addProductPartDataGrid";
            this.addProductPartDataGrid.Size = new System.Drawing.Size(376, 102);
            this.addProductPartDataGrid.TabIndex = 7;
            // 
            // addProductRelatedPArtsDataGrid
            // 
            this.addProductRelatedPArtsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductRelatedPArtsDataGrid.Location = new System.Drawing.Point(388, 277);
            this.addProductRelatedPArtsDataGrid.Name = "addProductRelatedPArtsDataGrid";
            this.addProductRelatedPArtsDataGrid.Size = new System.Drawing.Size(376, 102);
            this.addProductRelatedPArtsDataGrid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name of Product:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Inventory Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price of Product:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Min:";
            // 
            // addProductPartSearchButton
            // 
            this.addProductPartSearchButton.Location = new System.Drawing.Point(388, 49);
            this.addProductPartSearchButton.Name = "addProductPartSearchButton";
            this.addProductPartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.addProductPartSearchButton.TabIndex = 18;
            this.addProductPartSearchButton.Text = "Search";
            this.addProductPartSearchButton.UseVisualStyleBackColor = true;
            this.addProductPartSearchButton.Click += new System.EventHandler(this.addProductPartSearchButton_Click);
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.Location = new System.Drawing.Point(599, 414);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addProductSaveButton.TabIndex = 19;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = true;
            this.addProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // addProductCancelButton
            // 
            this.addProductCancelButton.Location = new System.Drawing.Point(689, 414);
            this.addProductCancelButton.Name = "addProductCancelButton";
            this.addProductCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addProductCancelButton.TabIndex = 20;
            this.addProductCancelButton.Text = "Cancel";
            this.addProductCancelButton.UseVisualStyleBackColor = true;
            this.addProductCancelButton.Click += new System.EventHandler(this.addProductCancelButton_Click);
            // 
            // addProductDeleteRelationButton
            // 
            this.addProductDeleteRelationButton.Location = new System.Drawing.Point(689, 385);
            this.addProductDeleteRelationButton.Name = "addProductDeleteRelationButton";
            this.addProductDeleteRelationButton.Size = new System.Drawing.Size(75, 23);
            this.addProductDeleteRelationButton.TabIndex = 21;
            this.addProductDeleteRelationButton.Text = "Delete";
            this.addProductDeleteRelationButton.UseVisualStyleBackColor = true;
            this.addProductDeleteRelationButton.Click += new System.EventHandler(this.addProductDeleteRelationButton_Click);
            // 
            // addProductAddRelationButton
            // 
            this.addProductAddRelationButton.Location = new System.Drawing.Point(689, 222);
            this.addProductAddRelationButton.Name = "addProductAddRelationButton";
            this.addProductAddRelationButton.Size = new System.Drawing.Size(75, 23);
            this.addProductAddRelationButton.TabIndex = 22;
            this.addProductAddRelationButton.Text = "Add";
            this.addProductAddRelationButton.UseVisualStyleBackColor = true;
            this.addProductAddRelationButton.Click += new System.EventHandler(this.addProductAddRelationButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addProductAddRelationButton);
            this.Controls.Add(this.addProductDeleteRelationButton);
            this.Controls.Add(this.addProductCancelButton);
            this.Controls.Add(this.addProductSaveButton);
            this.Controls.Add(this.addProductPartSearchButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProductRelatedPArtsDataGrid);
            this.Controls.Add(this.addProductPartDataGrid);
            this.Controls.Add(this.addProductSearchText);
            this.Controls.Add(this.addProductMinText);
            this.Controls.Add(this.addProductMaxText);
            this.Controls.Add(this.addProductPriceText);
            this.Controls.Add(this.addProductInvAmtText);
            this.Controls.Add(this.addProductNameText);
            this.Controls.Add(this.addProductIDText);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addProductPartDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductRelatedPArtsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addProductIDText;
        private System.Windows.Forms.TextBox addProductNameText;
        private System.Windows.Forms.TextBox addProductInvAmtText;
        private System.Windows.Forms.TextBox addProductPriceText;
        private System.Windows.Forms.TextBox addProductMaxText;
        private System.Windows.Forms.TextBox addProductMinText;
        private System.Windows.Forms.TextBox addProductSearchText;
        private System.Windows.Forms.DataGridView addProductPartDataGrid;
        private System.Windows.Forms.DataGridView addProductRelatedPArtsDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addProductPartSearchButton;
        private System.Windows.Forms.Button addProductSaveButton;
        private System.Windows.Forms.Button addProductCancelButton;
        private System.Windows.Forms.Button addProductDeleteRelationButton;
        private System.Windows.Forms.Button addProductAddRelationButton;
    }
}