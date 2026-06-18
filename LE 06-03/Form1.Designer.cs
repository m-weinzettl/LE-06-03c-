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
        TxtUserName = new System.Windows.Forms.TextBox();
        TxtPassword = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        BtnLogin = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // TxtUserName
        // 
        TxtUserName.Location = new System.Drawing.Point(160, 35);
        TxtUserName.Name = "TxtUserName";
        TxtUserName.Size = new System.Drawing.Size(202, 23);
        TxtUserName.TabIndex = 0;
        // 
        // TxtPassword
        // 
        TxtPassword.Location = new System.Drawing.Point(160, 64);
        TxtPassword.Name = "TxtPassword";
        TxtPassword.Size = new System.Drawing.Size(202, 23);
        TxtPassword.TabIndex = 1;
        // 
        // label1
        // 
        label1.AccessibleName = "";
        label1.Location = new System.Drawing.Point(39, 35);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(96, 22);
        label1.TabIndex = 2;
        label1.Text = "Benutzer";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(39, 64);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(96, 22);
        label2.TabIndex = 3;
        label2.Text = "Passwort";
        // 
        // BtnLogin
        // 
        BtnLogin.Location = new System.Drawing.Point(263, 93);
        BtnLogin.Name = "BtnLogin";
        BtnLogin.Size = new System.Drawing.Size(99, 25);
        BtnLogin.TabIndex = 4;
        BtnLogin.Text = "Login";
        BtnLogin.UseVisualStyleBackColor = true;
        BtnLogin.Click += BtnLogin_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(379, 146);
        Controls.Add(BtnLogin);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(TxtPassword);
        Controls.Add(TxtUserName);
        Text = "WPF Bau GesmbH";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox TxtUserName;
    private System.Windows.Forms.TextBox TxtPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BtnLogin;

    #endregion
}