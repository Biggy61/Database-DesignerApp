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
    private Login _login;
    public enum Forms
    {
        Language,
        Navigation,
        Registration,
        Users,
        Login,
    }
    public BaseForm()
    {
        InitializeComponent();
        _language = new Languages(this);
        _navigation = new Navigation(this);
        _registration = new Registration(this);
        _login = new Login(this);
        SwitchLanguage(Forms.Login);
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
            Forms.Login => _login,
        };
        Controls.Add(_currentView);
    }

}