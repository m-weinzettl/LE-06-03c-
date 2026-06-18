using System.ComponentModel;

namespace LE_06_03;

partial class InvoiceForm
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        LabelCustomerName = new System.Windows.Forms.Label();
        LabelCustomerNumber = new System.Windows.Forms.Label();
        TxtBoxCustomerName = new System.Windows.Forms.TextBox();
        TxtBoxCustomerNumber = new System.Windows.Forms.TextBox();
        TxtBoxItemDescription = new System.Windows.Forms.TextBox();
        TxtBoxQuantity = new System.Windows.Forms.TextBox();
        TxtBoxPricePerUnit = new System.Windows.Forms.TextBox();
        LabelItemDescription = new System.Windows.Forms.Label();
        LabelQuantity = new System.Windows.Forms.Label();
        LabelPricePerUnit = new System.Windows.Forms.Label();
        BtnCalculate = new System.Windows.Forms.Button();
        BtnSaveInvoice = new System.Windows.Forms.Button();
        LabelTotalResult = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // LabelCustomerName
        // 
        LabelCustomerName.Location = new System.Drawing.Point(14, 16);
        LabelCustomerName.Name = "LabelCustomerName";
        LabelCustomerName.Size = new System.Drawing.Size(119, 23);
        LabelCustomerName.TabIndex = 0;
        LabelCustomerName.Text = "Kundenname";
        // 
        // LabelCustomerNumber
        // 
        LabelCustomerNumber.Location = new System.Drawing.Point(14, 49);
        LabelCustomerNumber.Name = "LabelCustomerNumber";
        LabelCustomerNumber.Size = new System.Drawing.Size(119, 23);
        LabelCustomerNumber.TabIndex = 1;
        LabelCustomerNumber.Text = "Kundennummer";
        // 
        // TxtBoxCustomerName
        // 
        TxtBoxCustomerName.Location = new System.Drawing.Point(139, 16);
        TxtBoxCustomerName.Name = "TxtBoxCustomerName";
        TxtBoxCustomerName.Size = new System.Drawing.Size(279, 23);
        TxtBoxCustomerName.TabIndex = 2;
        // 
        // TxtBoxCustomerNumber
        // 
        TxtBoxCustomerNumber.Location = new System.Drawing.Point(139, 49);
        TxtBoxCustomerNumber.Name = "TxtBoxCustomerNumber";
        TxtBoxCustomerNumber.Size = new System.Drawing.Size(279, 23);
        TxtBoxCustomerNumber.TabIndex = 3;
        // 
        // TxtBoxItemDescription
        // 
        TxtBoxItemDescription.Location = new System.Drawing.Point(139, 106);
        TxtBoxItemDescription.Name = "TxtBoxItemDescription";
        TxtBoxItemDescription.Size = new System.Drawing.Size(279, 23);
        TxtBoxItemDescription.TabIndex = 4;
        // 
        // TxtBoxQuantity
        // 
        TxtBoxQuantity.Location = new System.Drawing.Point(139, 135);
        TxtBoxQuantity.Name = "TxtBoxQuantity";
        TxtBoxQuantity.Size = new System.Drawing.Size(279, 23);
        TxtBoxQuantity.TabIndex = 5;
        // 
        // TxtBoxPricePerUnit
        // 
        TxtBoxPricePerUnit.Location = new System.Drawing.Point(139, 164);
        TxtBoxPricePerUnit.Name = "TxtBoxPricePerUnit";
        TxtBoxPricePerUnit.Size = new System.Drawing.Size(279, 23);
        TxtBoxPricePerUnit.TabIndex = 6;
        // 
        // LabelItemDescription
        // 
        LabelItemDescription.Location = new System.Drawing.Point(12, 106);
        LabelItemDescription.Name = "LabelItemDescription";
        LabelItemDescription.Size = new System.Drawing.Size(119, 23);
        LabelItemDescription.TabIndex = 7;
        LabelItemDescription.Text = "Beschreibung";
        // 
        // LabelQuantity
        // 
        LabelQuantity.Location = new System.Drawing.Point(12, 135);
        LabelQuantity.Name = "LabelQuantity";
        LabelQuantity.Size = new System.Drawing.Size(119, 23);
        LabelQuantity.TabIndex = 8;
        LabelQuantity.Text = "Anzahl";
        // 
        // LabelPricePerUnit
        // 
        LabelPricePerUnit.Location = new System.Drawing.Point(12, 164);
        LabelPricePerUnit.Name = "LabelPricePerUnit";
        LabelPricePerUnit.Size = new System.Drawing.Size(119, 23);
        LabelPricePerUnit.TabIndex = 9;
        LabelPricePerUnit.Text = "Preis pro Stück";
        // 
        // BtnCalculate
        // 
        BtnCalculate.Location = new System.Drawing.Point(139, 205);
        BtnCalculate.Name = "BtnCalculate";
        BtnCalculate.Size = new System.Drawing.Size(130, 30);
        BtnCalculate.TabIndex = 10;
        BtnCalculate.Text = "Berechnen";
        BtnCalculate.UseVisualStyleBackColor = true;
        // 
        // BtnSaveInvoice
        // 
        BtnSaveInvoice.Location = new System.Drawing.Point(288, 205);
        BtnSaveInvoice.Name = "BtnSaveInvoice";
        BtnSaveInvoice.Size = new System.Drawing.Size(130, 30);
        BtnSaveInvoice.TabIndex = 11;
        BtnSaveInvoice.Text = "Speichern";
        BtnSaveInvoice.UseVisualStyleBackColor = true;
        // 
        // LabelTotalResult
        // 
        LabelTotalResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        LabelTotalResult.Location = new System.Drawing.Point(139, 255);
        LabelTotalResult.Name = "LabelTotalResult";
        LabelTotalResult.Size = new System.Drawing.Size(279, 30);
        LabelTotalResult.TabIndex = 12;
        LabelTotalResult.Text = "Gesamtpreis (inkl. 20% MwSt.): 0,00 €";
        // 
        // InvoiceForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(LabelTotalResult);
        Controls.Add(BtnSaveInvoice);
        Controls.Add(BtnCalculate);
        Controls.Add(LabelPricePerUnit);
        Controls.Add(LabelQuantity);
        Controls.Add(LabelItemDescription);
        Controls.Add(TxtBoxPricePerUnit);
        Controls.Add(TxtBoxQuantity);
        Controls.Add(TxtBoxItemDescription);
        Controls.Add(TxtBoxCustomerNumber);
        Controls.Add(TxtBoxCustomerName);
        Controls.Add(LabelCustomerNumber);
        Controls.Add(LabelCustomerName);
        Text = "Rechnungsverwaltung";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label LabelCustomerName;
    private System.Windows.Forms.Label LabelCustomerNumber;
    private System.Windows.Forms.TextBox TxtBoxCustomerName;
    private System.Windows.Forms.TextBox TxtBoxCustomerNumber;
    private System.Windows.Forms.TextBox TxtBoxItemDescription;
    private System.Windows.Forms.TextBox TxtBoxQuantity;
    private System.Windows.Forms.TextBox TxtBoxPricePerUnit;
    private System.Windows.Forms.Label LabelItemDescription;
    private System.Windows.Forms.Label LabelQuantity;
    private System.Windows.Forms.Label LabelPricePerUnit;
    private System.Windows.Forms.Button BtnCalculate;
    private System.Windows.Forms.Button BtnSaveInvoice;
    private System.Windows.Forms.Label LabelTotalResult;

    #endregion
}