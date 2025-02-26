namespace DatabaseViewForm.Nav;

public partial class Users : UserControl
{
    private readonly BaseForm _parentForm;
    
    public Users(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchLanguage(BaseForm.Forms.Navigation);
    }
}