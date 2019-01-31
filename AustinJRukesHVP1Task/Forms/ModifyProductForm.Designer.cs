namespace AustinJRukesHVP1Task.Forms
{
    partial class ModifyProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.modifyProductPartSearchButton = new System.Windows.Forms.Button();
            this.modifyProductSearchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modifyProductIDText = new System.Windows.Forms.TextBox();
            this.modifyProductNameText = new System.Windows.Forms.TextBox();
            this.modifyProductInvAmtText = new System.Windows.Forms.TextBox();
            this.modifyProductPriceText = new System.Windows.Forms.TextBox();
            this.modifyProductMaxText = new System.Windows.Forms.TextBox();
            this.modifyProductMinText = new System.Windows.Forms.TextBox();
            this.modifyProductPartDataGrid = new System.Windows.Forms.DataGridView();
            this.modifyProductRelatedPArtsDataGrid = new System.Windows.Forms.DataGridView();
            this.modifyProductDeleteRelationButton = new System.Windows.Forms.Button();
            this.modifyProductSaveButton = new System.Windows.Forms.Button();
            this.modifyProductCancelButton = new System.Windows.Forms.Button();
            this.modifyProductAddRelationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductPartDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductRelatedPArtsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modify Product";
            // 
            // modifyProductPartSearchButton
            // 
            this.modifyProductPartSearchButton.Location = new System.Drawing.Point(397, 46);
            this.modifyProductPartSearchButton.Name = "modifyProductPartSearchButton";
            this.modifyProductPartSearchButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductPartSearchButton.TabIndex = 19;
            this.modifyProductPartSearchButton.Text = "Search";
            this.modifyProductPartSearchButton.UseVisualStyleBackColor = true;
            this.modifyProductPartSearchButton.Click += new System.EventHandler(this.modifyProductPartSearchButton_Click);
            // 
            // modifyProductSearchText
            // 
            this.modifyProductSearchText.Location = new System.Drawing.Point(528, 49);
            this.modifyProductSearchText.Name = "modifyProductSearchText";
            this.modifyProductSearchText.Size = new System.Drawing.Size(183, 20);
            this.modifyProductSearchText.TabIndex = 20;
            this.modifyProductSearchText.TextChanged += new System.EventHandler(this.modifyProductSearchText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name of Product:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Inventory Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price of Product:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Min:";
            // 
            // modifyProductIDText
            // 
            this.modifyProductIDText.Enabled = false;
            this.modifyProductIDText.Location = new System.Drawing.Point(146, 109);
            this.modifyProductIDText.Name = "modifyProductIDText";
            this.modifyProductIDText.Size = new System.Drawing.Size(100, 20);
            this.modifyProductIDText.TabIndex = 27;
            // 
            // modifyProductNameText
            // 
            this.modifyProductNameText.Location = new System.Drawing.Point(146, 153);
            this.modifyProductNameText.Name = "modifyProductNameText";
            this.modifyProductNameText.Size = new System.Drawing.Size(100, 20);
            this.modifyProductNameText.TabIndex = 28;
            // 
            // modifyProductInvAmtText
            // 
            this.modifyProductInvAmtText.Location = new System.Drawing.Point(146, 197);
            this.modifyProductInvAmtText.Name = "modifyProductInvAmtText";
            this.modifyProductInvAmtText.Size = new System.Drawing.Size(59, 20);
            this.modifyProductInvAmtText.TabIndex = 29;
            // 
            // modifyProductPriceText
            // 
            this.modifyProductPriceText.Location = new System.Drawing.Point(146, 245);
            this.modifyProductPriceText.Name = "modifyProductPriceText";
            this.modifyProductPriceText.Size = new System.Drawing.Size(59, 20);
            this.modifyProductPriceText.TabIndex = 30;
            // 
            // modifyProductMaxText
            // 
            this.modifyProductMaxText.Location = new System.Drawing.Point(146, 304);
            this.modifyProductMaxText.Name = "modifyProductMaxText";
            this.modifyProductMaxText.Size = new System.Drawing.Size(59, 20);
            this.modifyProductMaxText.TabIndex = 31;
            // 
            // modifyProductMinText
            // 
            this.modifyProductMinText.Location = new System.Drawing.Point(289, 304);
            this.modifyProductMinText.Name = "modifyProductMinText";
            this.modifyProductMinText.Size = new System.Drawing.Size(59, 20);
            this.modifyProductMinText.TabIndex = 32;
            // 
            // modifyProductPartDataGrid
            // 
            this.modifyProductPartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductPartDataGrid.Location = new System.Drawing.Point(397, 112);
            this.modifyProductPartDataGrid.Name = "modifyProductPartDataGrid";
            this.modifyProductPartDataGrid.Size = new System.Drawing.Size(376, 102);
            this.modifyProductPartDataGrid.TabIndex = 33;
            // 
            // modifyProductRelatedPArtsDataGrid
            // 
            this.modifyProductRelatedPArtsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductRelatedPArtsDataGrid.Location = new System.Drawing.Point(397, 271);
            this.modifyProductRelatedPArtsDataGrid.Name = "modifyProductRelatedPArtsDataGrid";
            this.modifyProductRelatedPArtsDataGrid.Size = new System.Drawing.Size(376, 102);
            this.modifyProductRelatedPArtsDataGrid.TabIndex = 34;
            // 
            // modifyProductDeleteRelationButton
            // 
            this.modifyProductDeleteRelationButton.Location = new System.Drawing.Point(698, 379);
            this.modifyProductDeleteRelationButton.Name = "modifyProductDeleteRelationButton";
            this.modifyProductDeleteRelationButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductDeleteRelationButton.TabIndex = 35;
            this.modifyProductDeleteRelationButton.Text = "Delete";
            this.modifyProductDeleteRelationButton.UseVisualStyleBackColor = true;
            this.modifyProductDeleteRelationButton.Click += new System.EventHandler(this.modifyProductDeleteRelationButton_Click);
            // 
            // modifyProductSaveButton
            // 
            this.modifyProductSaveButton.Location = new System.Drawing.Point(600, 415);
            this.modifyProductSaveButton.Name = "modifyProductSaveButton";
            this.modifyProductSaveButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductSaveButton.TabIndex = 36;
            this.modifyProductSaveButton.Text = "Save";
            this.modifyProductSaveButton.UseVisualStyleBackColor = true;
            this.modifyProductSaveButton.Click += new System.EventHandler(this.modifyProductSaveButton_Click);
            // 
            // modifyProductCancelButton
            // 
            this.modifyProductCancelButton.Location = new System.Drawing.Point(698, 415);
            this.modifyProductCancelButton.Name = "modifyProductCancelButton";
            this.modifyProductCancelButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductCancelButton.TabIndex = 37;
            this.modifyProductCancelButton.Text = "Cancel";
            this.modifyProductCancelButton.UseVisualStyleBackColor = true;
            this.modifyProductCancelButton.Click += new System.EventHandler(this.modifyProductCancelButton_Click);
            // 
            // modifyProductAddRelationButton
            // 
            this.modifyProductAddRelationButton.Location = new System.Drawing.Point(698, 220);
            this.modifyProductAddRelationButton.Name = "modifyProductAddRelationButton";
            this.modifyProductAddRelationButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductAddRelationButton.TabIndex = 38;
            this.modifyProductAddRelationButton.Text = "Add";
            this.modifyProductAddRelationButton.UseVisualStyleBackColor = true;
            this.modifyProductAddRelationButton.Click += new System.EventHandler(this.modifyProductAddRelationButton_Click);
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifyProductAddRelationButton);
            this.Controls.Add(this.modifyProductCancelButton);
            this.Controls.Add(this.modifyProductSaveButton);
            this.Controls.Add(this.modifyProductDeleteRelationButton);
            this.Controls.Add(this.modifyProductRelatedPArtsDataGrid);
            this.Controls.Add(this.modifyProductPartDataGrid);
            this.Controls.Add(this.modifyProductMinText);
            this.Controls.Add(this.modifyProductMaxText);
            this.Controls.Add(this.modifyProductPriceText);
            this.Controls.Add(this.modifyProductInvAmtText);
            this.Controls.Add(this.modifyProductNameText);
            this.Controls.Add(this.modifyProductIDText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifyProductSearchText);
            this.Controls.Add(this.modifyProductPartSearchButton);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProductForm";
            this.Text = "ModifyProductForm";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductPartDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductRelatedPArtsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyProductPartSearchButton;
        private System.Windows.Forms.TextBox modifyProductSearchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView modifyProductPartDataGrid;
        private System.Windows.Forms.DataGridView modifyProductRelatedPArtsDataGrid;
        private System.Windows.Forms.Button modifyProductDeleteRelationButton;
        private System.Windows.Forms.Button modifyProductSaveButton;
        private System.Windows.Forms.Button modifyProductCancelButton;
        private System.Windows.Forms.Button modifyProductAddRelationButton;
        public System.Windows.Forms.TextBox modifyProductIDText;
        public System.Windows.Forms.TextBox modifyProductNameText;
        public System.Windows.Forms.TextBox modifyProductInvAmtText;
        public System.Windows.Forms.TextBox modifyProductPriceText;
        public System.Windows.Forms.TextBox modifyProductMaxText;
        public System.Windows.Forms.TextBox modifyProductMinText;
    }
}