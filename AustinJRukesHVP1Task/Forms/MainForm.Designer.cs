namespace AustinJRukesHVP1Task
{
    partial class MainForm
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
            this.partsPanel = new System.Windows.Forms.Panel();
            this.partsSearchTextbox = new System.Windows.Forms.TextBox();
            this.deletePartsButton = new System.Windows.Forms.Button();
            this.modifyPartsButton = new System.Windows.Forms.Button();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.productsSearchTextbox = new System.Windows.Forms.TextBox();
            this.productsDeleteButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.productLabel = new System.Windows.Forms.Label();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.projectLabel = new System.Windows.Forms.Label();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.partsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partsPanel
            // 
            this.partsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.partsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsPanel.Controls.Add(this.partsSearchTextbox);
            this.partsPanel.Controls.Add(this.deletePartsButton);
            this.partsPanel.Controls.Add(this.modifyPartsButton);
            this.partsPanel.Controls.Add(this.partsAddButton);
            this.partsPanel.Controls.Add(this.partsSearchButton);
            this.partsPanel.Controls.Add(this.partsLabel);
            this.partsPanel.Controls.Add(this.partsDataGridView);
            this.partsPanel.Location = new System.Drawing.Point(28, 83);
            this.partsPanel.Name = "partsPanel";
            this.partsPanel.Size = new System.Drawing.Size(402, 273);
            this.partsPanel.TabIndex = 0;
            // 
            // partsSearchTextbox
            // 
            this.partsSearchTextbox.Location = new System.Drawing.Point(255, 27);
            this.partsSearchTextbox.Name = "partsSearchTextbox";
            this.partsSearchTextbox.Size = new System.Drawing.Size(112, 20);
            this.partsSearchTextbox.TabIndex = 6;
            this.partsSearchTextbox.TextChanged += new System.EventHandler(this.partsSearchTextbox_TextChanged);
            // 
            // deletePartsButton
            // 
            this.deletePartsButton.Location = new System.Drawing.Point(280, 237);
            this.deletePartsButton.Name = "deletePartsButton";
            this.deletePartsButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartsButton.TabIndex = 5;
            this.deletePartsButton.Text = "Delete";
            this.deletePartsButton.UseVisualStyleBackColor = true;
            this.deletePartsButton.Click += new System.EventHandler(this.deletePartsButton_Click);
            // 
            // modifyPartsButton
            // 
            this.modifyPartsButton.Location = new System.Drawing.Point(199, 237);
            this.modifyPartsButton.Name = "modifyPartsButton";
            this.modifyPartsButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartsButton.TabIndex = 4;
            this.modifyPartsButton.Text = "Modify";
            this.modifyPartsButton.UseVisualStyleBackColor = true;
            this.modifyPartsButton.Click += new System.EventHandler(this.modifyPartsButton_Click);
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(118, 237);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(75, 23);
            this.partsAddButton.TabIndex = 3;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(167, 25);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partsSearchButton.TabIndex = 2;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(33, 24);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(56, 24);
            this.partsLabel.TabIndex = 1;
            this.partsLabel.Text = "Parts";
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(33, 70);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.Size = new System.Drawing.Size(334, 150);
            this.partsDataGridView.TabIndex = 0;
            // 
            // productsPanel
            // 
            this.productsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsPanel.Controls.Add(this.productsSearchTextbox);
            this.productsPanel.Controls.Add(this.productsDeleteButton);
            this.productsPanel.Controls.Add(this.productsModifyButton);
            this.productsPanel.Controls.Add(this.productsAddButton);
            this.productsPanel.Controls.Add(this.productsSearchButton);
            this.productsPanel.Controls.Add(this.productLabel);
            this.productsPanel.Controls.Add(this.productsDataGridView);
            this.productsPanel.Location = new System.Drawing.Point(612, 83);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(402, 273);
            this.productsPanel.TabIndex = 1;
            // 
            // productsSearchTextbox
            // 
            this.productsSearchTextbox.Location = new System.Drawing.Point(255, 27);
            this.productsSearchTextbox.Name = "productsSearchTextbox";
            this.productsSearchTextbox.Size = new System.Drawing.Size(112, 20);
            this.productsSearchTextbox.TabIndex = 7;
            this.productsSearchTextbox.TextChanged += new System.EventHandler(this.productsSearchTextbox_TextChanged);
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(276, 237);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.productsDeleteButton.TabIndex = 5;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            this.productsDeleteButton.Click += new System.EventHandler(this.productsDeleteButton_Click);
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(195, 237);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.productsModifyButton.TabIndex = 4;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            this.productsModifyButton.Click += new System.EventHandler(this.productsModifyButton_Click);
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(114, 237);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(75, 23);
            this.productsAddButton.TabIndex = 3;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            this.productsAddButton.Click += new System.EventHandler(this.productsAddButton_Click);
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(158, 25);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 2;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.productsSearchButton_Click);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(27, 25);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(92, 24);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Products";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(31, 70);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(336, 150);
            this.productsDataGridView.TabIndex = 0;
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.projectLabel.Location = new System.Drawing.Point(28, 29);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(268, 24);
            this.projectLabel.TabIndex = 2;
            this.projectLabel.Text = "Inventory Management System";
            // 
            // exitAppButton
            // 
            this.exitAppButton.Location = new System.Drawing.Point(888, 391);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(115, 47);
            this.exitAppButton.TabIndex = 3;
            this.exitAppButton.Text = "Exit";
            this.exitAppButton.UseVisualStyleBackColor = true;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.partsPanel);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.partsPanel.ResumeLayout(false);
            this.partsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel partsPanel;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button deletePartsButton;
        private System.Windows.Forms.Button modifyPartsButton;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.DataGridView partsDataGridView;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.TextBox partsSearchTextbox;
        private System.Windows.Forms.TextBox productsSearchTextbox;
        private System.Windows.Forms.Button productsDeleteButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Button exitAppButton;
    }
}

