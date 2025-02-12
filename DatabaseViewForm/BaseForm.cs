using DatabaseViewForm.Nav;

namespace DatabaseViewForm;

public partial class BaseForm : Form
{
    public DBDriver _dbDriver;
    private Languages _language;
    private Navigation _navigation;
    private Registration _registration;
    private Users _users;
    private UserControl _currentView;
    public enum Forms
    {
        Language,
        Navigation,
        Registration,
        Users,
    }
    public BaseForm()
    {
        InitializeComponent();
        _language = new Languages(this);
        _navigation = new Navigation(this);
        _registration = new Registration(this);
        SwitchLanguage(Forms.Navigation);
    }

    public void SwitchLanguage(Forms form)
    {
        Controls.Remove(_currentView);
        _currentView = form switch
        {
            Forms.Language => _language,
            Forms.Navigation => _navigation,
            Forms.Registration => _registration,
            Forms.Users => _users,
        };
        Controls.Add(_currentView);
    }

    private void PasswordButton_Click(object sender, EventArgs e)
    {
        Login();
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

    private void Login()
    {
        ErrorLabel.Text = "";
        if (_dbDriver is null)
        {
            _dbDriver = new DBDriver(PasswordTextBox.Text);
            
        }

        PasswordTextBox.Text = "";
    }

    private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Login();
            
        }
    }
}