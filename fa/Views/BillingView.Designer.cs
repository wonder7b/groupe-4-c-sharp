namespace fa.Views
{
    partial class BillingView
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
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subTotalValueLabel = new System.Windows.Forms.Label();
            this.taxValueLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.totalsPanel = new System.Windows.Forms.Panel();
            this.deleteFromCartButton = new System.Windows.Forms.Button();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.productSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.foundProductNameLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.totalsPanel.SuspendLayout();
            this.customerInfoGroupBox.SuspendLayout();
            this.productSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Location = new System.Drawing.Point(10, 170);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.Size = new System.Drawing.Size(580, 214);
            this.cartDataGridView.TabIndex = 6;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printReceiptButton.Location = new System.Drawing.Point(430, 55);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(150, 30);
            this.printReceiptButton.TabIndex = 7;
            this.printReceiptButton.Text = "Finaliser et Nouveau Ticket";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subTotalLabel.Location = new System.Drawing.Point(3, 10);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(68, 15);
            this.subTotalLabel.TabIndex = 8;
            this.subTotalLabel.Text = "Sous-total :";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taxLabel.Location = new System.Drawing.Point(3, 34);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(33, 15);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "TVA :";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(3, 58);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 21);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total :";
            //
            // subTotalValueLabel
            //
            this.subTotalValueLabel.AutoSize = true;
            this.subTotalValueLabel.Location = new System.Drawing.Point(93, 10);
            this.subTotalValueLabel.Name = "subTotalValueLabel";
            this.subTotalValueLabel.Size = new System.Drawing.Size(28, 15);
            this.subTotalValueLabel.TabIndex = 11;
            this.subTotalValueLabel.Text = "0.00";
            //
            // taxValueLabel
            //
            this.taxValueLabel.AutoSize = true;
            this.taxValueLabel.Location = new System.Drawing.Point(93, 34);
            this.taxValueLabel.Name = "taxValueLabel";
            this.taxValueLabel.Size = new System.Drawing.Size(28, 15);
            this.taxValueLabel.TabIndex = 12;
            this.taxValueLabel.Text = "0.00";
            //
            // totalValueLabel
            //
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalValueLabel.Location = new System.Drawing.Point(93, 58);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(45, 21);
            this.totalValueLabel.TabIndex = 13;
            this.totalValueLabel.Text = "0.00";
            // 
            // totalsPanel
            //
            this.totalsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalsPanel.Controls.Add(this.subTotalLabel);
            this.totalsPanel.Controls.Add(this.taxLabel);
            this.totalsPanel.Controls.Add(this.totalLabel);
            this.totalsPanel.Controls.Add(this.subTotalValueLabel);
            this.totalsPanel.Controls.Add(this.taxValueLabel);
            this.totalsPanel.Controls.Add(this.totalValueLabel);
            this.totalsPanel.Controls.Add(this.printReceiptButton);
            this.totalsPanel.Location = new System.Drawing.Point(10, 390);
            this.totalsPanel.Name = "totalsPanel";
            this.totalsPanel.Size = new System.Drawing.Size(580, 100);
            this.totalsPanel.TabIndex = 15;
            // 
            // deleteFromCartButton
            // 
            this.deleteFromCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFromCartButton.Location = new System.Drawing.Point(440, 134);
            this.deleteFromCartButton.Name = "deleteFromCartButton";
            this.deleteFromCartButton.Size = new System.Drawing.Size(150, 30);
            this.deleteFromCartButton.TabIndex = 5;
            this.deleteFromCartButton.Text = "Retirer du Panier";
            this.deleteFromCartButton.UseVisualStyleBackColor = true;
            //
            // customerInfoGroupBox
            //
            this.customerInfoGroupBox.Controls.Add(this.customerPhoneTextBox);
            this.customerInfoGroupBox.Controls.Add(this.customerNameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.customerPhoneLabel);
            this.customerInfoGroupBox.Controls.Add(this.customerNameLabel);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(10, 10);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(280, 118);
            this.customerInfoGroupBox.TabIndex = 16;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Informations du Client";
            //
            // customerPhoneTextBox
            //
            this.customerPhoneTextBox.Location = new System.Drawing.Point(110, 70);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(160, 23);
            this.customerPhoneTextBox.TabIndex = 3;
            //
            // customerNameTextBox
            //
            this.customerNameTextBox.Location = new System.Drawing.Point(110, 32);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(160, 23);
            this.customerNameTextBox.TabIndex = 2;
            //
            // customerPhoneLabel
            //
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(10, 73);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(94, 15);
            this.customerPhoneLabel.TabIndex = 1;
            this.customerPhoneLabel.Text = "N° de téléphone :";
            //
            // customerNameLabel
            //
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(10, 35);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(84, 15);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Nom du client :";
            //
            // productSearchGroupBox
            //
            this.productSearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productSearchGroupBox.Controls.Add(this.foundProductNameLabel);
            this.productSearchGroupBox.Controls.Add(this.addToCartButton);
            this.productSearchGroupBox.Controls.Add(this.quantityNumericUpDown);
            this.productSearchGroupBox.Controls.Add(this.quantityLabel);
            this.productSearchGroupBox.Controls.Add(this.searchProductButton);
            this.productSearchGroupBox.Controls.Add(this.productCodeTextBox);
            this.productSearchGroupBox.Controls.Add(this.productCodeLabel);
            this.productSearchGroupBox.Location = new System.Drawing.Point(300, 10);
            this.productSearchGroupBox.Name = "productSearchGroupBox";
            this.productSearchGroupBox.Size = new System.Drawing.Size(290, 118);
            this.productSearchGroupBox.TabIndex = 17;
            this.productSearchGroupBox.TabStop = false;
            this.productSearchGroupBox.Text = "Recherche de Produit";
            //
            // foundProductNameLabel
            //
            this.foundProductNameLabel.AutoSize = true;
            this.foundProductNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.foundProductNameLabel.Location = new System.Drawing.Point(10, 58);
            this.foundProductNameLabel.Name = "foundProductNameLabel";
            this.foundProductNameLabel.Size = new System.Drawing.Size(154, 15);
            this.foundProductNameLabel.TabIndex = 6;
            this.foundProductNameLabel.Text = "Aucun produit sélectionné";
            //
            // addToCartButton
            //
            this.addToCartButton.Enabled = false;
            this.addToCartButton.Location = new System.Drawing.Point(180, 80);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(100, 30);
            this.addToCartButton.TabIndex = 5;
            this.addToCartButton.Text = "Ajouter";
            this.addToCartButton.UseVisualStyleBackColor = true;
            //
            // quantityNumericUpDown
            //
            this.quantityNumericUpDown.Location = new System.Drawing.Point(70, 85);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.quantityNumericUpDown.TabIndex = 4;
            this.quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // quantityLabel
            //
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(10, 88);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(56, 15);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantité :";
            //
            // searchProductButton
            //
            this.searchProductButton.Location = new System.Drawing.Point(180, 29);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(100, 25);
            this.searchProductButton.TabIndex = 2;
            this.searchProductButton.Text = "Rechercher";
            this.searchProductButton.UseVisualStyleBackColor = true;
            //
            // productCodeTextBox
            //
            this.productCodeTextBox.Location = new System.Drawing.Point(70, 30);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.productCodeTextBox.TabIndex = 1;
            //
            // productCodeLabel
            //
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(10, 33);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(38, 15);
            this.productCodeLabel.TabIndex = 0;
            this.productCodeLabel.Text = "Code :";
            // 
            // BillingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productSearchGroupBox);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.deleteFromCartButton);
            this.Controls.Add(this.cartDataGridView);
            this.Controls.Add(this.totalsPanel);
            this.Name = "BillingView";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.totalsPanel.ResumeLayout(false);
            this.totalsPanel.PerformLayout();
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.productSearchGroupBox.ResumeLayout(false);
            this.productSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subTotalValueLabel;
        private System.Windows.Forms.Label taxValueLabel;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Panel totalsPanel;
        private System.Windows.Forms.Button deleteFromCartButton;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerPhoneLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox productSearchGroupBox;
        private System.Windows.Forms.Label foundProductNameLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label productCodeLabel;
    }
}
