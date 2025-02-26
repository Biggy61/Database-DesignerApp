namespace DatabaseViewForm.Nav;

public partial class Navigation : UserControl
{
    private readonly BaseForm _parentForm;
    
    public Navigation(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void Navigation_Load(object sender, EventArgs e)
    {
        
    }

    private void UserButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchLanguage(BaseForm.Forms.Users);
    }

    private void LanguageButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchLanguage(BaseForm.Forms.Language);
    }

    private void LanguageRegistrationButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchLanguage(BaseForm.Forms.Registration);
    }
}