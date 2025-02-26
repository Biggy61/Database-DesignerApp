namespace DatabaseViewForm.Nav;

public partial class Registration : UserControl
{
    private readonly BaseForm _parentForm;
    
    public Registration(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchLanguage(BaseForm.Forms.Navigation);
    }
}