namespace DatabaseViewForm.Nav;

public partial class Login : UserControl
{
    private readonly BaseForm _parentForm;
    public DBDriver _dbDriver;
    public Login(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }
    private void PasswordButton_Click(object sender, EventArgs e)
    {
        LogIn();
    }


    private void PasswordTextBox_Enter(object sender, EventArgs e)
    {
        PasswordTextBox.Text = "";

        PasswordTextBox.ForeColor = Color.Black;

        PasswordTextBox.UseSystemPasswordChar = true;
    }

    private void PasswordTextBox_Leave(object sender, EventArgs e)
    {
        if (PasswordTextBox.Text.Length == 0)
        {
            PasswordTextBox.ForeColor = Color.Gray;

            PasswordTextBox.Text = "Enter password";

            PasswordTextBox.UseSystemPasswordChar = false;

            SelectNextControl(PasswordTextBox, true, true, false, true);
        }
    }

    private void LogIn()
    {
        ErrorLabel.Text = "";
        if (_dbDriver is null)
        {
            _dbDriver = new DBDriver(PasswordTextBox.Text);
            _parentForm.SwitchLanguage(BaseForm.Forms.Navigation);
        }

        PasswordTextBox.Text = "";
        
    }

    private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            LogIn();
        }
    }
}