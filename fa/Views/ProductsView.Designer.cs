namespace fa.Views
{
    partial class ProductsView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.taxCategoryLabel = new System.Windows.Forms.Label();
            this.taxCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(15, 35);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(41, 15);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Code :";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(120, 32);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(200, 23);
            this.codeTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nom :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(120, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 23);
            this.nameTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(15, 115);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 15);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Prix :";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(120, 113);
            this.priceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(200, 23);
            this.priceNumericUpDown.TabIndex = 5;
            // 
            // taxCategoryLabel
            // 
            this.taxCategoryLabel.AutoSize = true;
            this.taxCategoryLabel.Location = new System.Drawing.Point(15, 155);
            this.taxCategoryLabel.Name = "taxCategoryLabel";
            this.taxCategoryLabel.Size = new System.Drawing.Size(89, 15);
            this.taxCategoryLabel.TabIndex = 6;
            this.taxCategoryLabel.Text = "Catégorie TVA :";
            // 
            // taxCategoryComboBox
            // 
            this.taxCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taxCategoryComboBox.FormattingEnabled = true;
            this.taxCategoryComboBox.Location = new System.Drawing.Point(120, 152);
            this.taxCategoryComboBox.Name = "taxCategoryComboBox";
            this.taxCategoryComboBox.Size = new System.Drawing.Size(200, 23);
            this.taxCategoryComboBox.TabIndex = 7;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(3, 3);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(100, 30);
            this.addProductButton.TabIndex = 8;
            this.addProductButton.Text = "Enregistrer";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Enabled = false;
            this.deleteProductButton.Location = new System.Drawing.Point(109, 3);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(100, 30);
            this.deleteProductButton.TabIndex = 9;
            this.deleteProductButton.Text = "Supprimer";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(215, 3);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(100, 30);
            this.clearFormButton.TabIndex = 10;
            this.clearFormButton.Text = "Nouveau";
            this.clearFormButton.UseVisualStyleBackColor = true;
            //
            // buttonsPanel
            //
            this.buttonsPanel.Controls.Add(this.addProductButton);
            this.buttonsPanel.Controls.Add(this.deleteProductButton);
            this.buttonsPanel.Controls.Add(this.clearFormButton);
            this.buttonsPanel.Location = new System.Drawing.Point(120, 190);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(320, 35);
            this.buttonsPanel.TabIndex = 11;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(10, 240);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(580, 250);
            this.productsDataGridView.TabIndex = 12;
            //
            // groupBox
            //
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.codeLabel);
            this.groupBox.Controls.Add(this.codeTextBox);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Controls.Add(this.nameTextBox);
            this.groupBox.Controls.Add(this.priceLabel);
            this.groupBox.Controls.Add(this.priceNumericUpDown);
            this.groupBox.Controls.Add(this.taxCategoryLabel);
            this.groupBox.Controls.Add(this.taxCategoryComboBox);
            this.groupBox.Controls.Add(this.buttonsPanel);
            this.groupBox.Location = new System.Drawing.Point(10, 10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(580, 225);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Détails du Produit";
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.productsDataGridView);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label taxCategoryLabel;
        private System.Windows.Forms.ComboBox taxCategoryComboBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
    }
}

