namespace DatabaseViewForm.Nav;

public partial class Navigation : UserControl
{
    private readonly BaseForm _parentForm;
    
    public Navigation(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }
    
}