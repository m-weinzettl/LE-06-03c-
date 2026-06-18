namespace LE_06_03;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void BtnLogin_Click(object sender, EventArgs e)
    {
        string UsernameInput = TxtUserName.Text.Trim();
        string PasswordInput = TxtPassword.Text.Trim();

        if (UsernameInput == AdminLoginData.username &&  PasswordInput == AdminLoginData.password)
        {
            MessageBox.Show("Anmeldung erfolgreich!", 
                "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Falscher Benutzername oder Passwort.", 
                "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}