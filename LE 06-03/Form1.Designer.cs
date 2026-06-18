namespace LE_06_03;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(160, 35);
        textBox1.Name = "TxtBoxUsername";
        textBox1.Size = new System.Drawing.Size(304, 23);
        textBox1.TabIndex = 0;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(160, 64);
        textBox2.Name = "TxtBoxPassword";
        textBox2.Size = new System.Drawing.Size(304, 23);
        textBox2.TabIndex = 1;
        // 
        // label1
        // 
        label1.AccessibleName = "";
        label1.Location = new System.Drawing.Point(39, 35);
        label1.Name = "LabelUsername";
        label1.Size = new System.Drawing.Size(96, 22);
        label1.TabIndex = 2;
        label1.Text = "Benutzer";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(39, 64);
        label2.Name = "LabelPassword";
        label2.Size = new System.Drawing.Size(96, 22);
        label2.TabIndex = 3;
        label2.Text = "Passwort";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(364, 97);
        button1.Name = "BtnLogin";
        button1.Size = new System.Drawing.Size(99, 25);
        button1.TabIndex = 4;
        button1.Text = "Login";
        button1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(497, 165);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Text = "WPF Bau GesmbH";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;

    #endregion
}