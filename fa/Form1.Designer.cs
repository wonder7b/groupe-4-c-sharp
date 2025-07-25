namespace fa;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.navigationPanel = new System.Windows.Forms.FlowLayoutPanel();
        this.billingButton = new System.Windows.Forms.Button();
        this.productsButton = new System.Windows.Forms.Button();
        this.mainPanel = new System.Windows.Forms.Panel();
        this.statusStrip = new System.Windows.Forms.StatusStrip();
        this.cashierStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        this.navigationPanel.SuspendLayout();
        this.statusStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // navigationPanel
        // 
        this.navigationPanel.Controls.Add(this.billingButton);
        this.navigationPanel.Controls.Add(this.productsButton);
        this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
        this.navigationPanel.Location = new System.Drawing.Point(0, 0);
        this.navigationPanel.Name = "navigationPanel";
        this.navigationPanel.Size = new System.Drawing.Size(800, 40);
        this.navigationPanel.TabIndex = 0;
        // 
        // billingButton
        // 
        this.billingButton.Location = new System.Drawing.Point(3, 3);
        this.billingButton.Name = "billingButton";
        this.billingButton.Size = new System.Drawing.Size(120, 34);
        this.billingButton.TabIndex = 0;
        this.billingButton.Text = "Facturation";
        this.billingButton.UseVisualStyleBackColor = true;
        // 
        // productsButton
        // 
        this.productsButton.Location = new System.Drawing.Point(129, 3);
        this.productsButton.Name = "productsButton";
        this.productsButton.Size = new System.Drawing.Size(120, 34);
        this.productsButton.TabIndex = 1;
        this.productsButton.Text = "Produits";
        this.productsButton.UseVisualStyleBackColor = true;
        // 
        // mainPanel
        // 
        this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mainPanel.Location = new System.Drawing.Point(0, 40);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Size = new System.Drawing.Size(800, 388);
        this.mainPanel.TabIndex = 1;
        // 
        // statusStrip
        // 
        this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.cashierStatusLabel});
        this.statusStrip.Location = new System.Drawing.Point(0, 428);
        this.statusStrip.Name = "statusStrip";
        this.statusStrip.Size = new System.Drawing.Size(800, 22);
        this.statusStrip.TabIndex = 2;
        this.statusStrip.Text = "statusStrip1";
        // 
        // cashierStatusLabel
        // 
        this.cashierStatusLabel.Name = "cashierStatusLabel";
        this.cashierStatusLabel.Size = new System.Drawing.Size(118, 17);
        this.cashierStatusLabel.Text = "Caissier: Non connecté";
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.mainPanel);
        this.Controls.Add(this.statusStrip);
        this.Controls.Add(this.navigationPanel);
        this.Name = "Form1";
        this.Text = "Système de Facturation";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.navigationPanel.ResumeLayout(false);
        this.statusStrip.ResumeLayout(false);
        this.statusStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel navigationPanel;
    private System.Windows.Forms.Button billingButton;
    private System.Windows.Forms.Button productsButton;
    private System.Windows.Forms.Panel mainPanel;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel cashierStatusLabel;
}