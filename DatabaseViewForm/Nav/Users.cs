namespace DatabaseViewForm.Nav;

public partial class Users : UserControl
{
    private readonly BaseForm _parentForm;
    
    public Users(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }
}