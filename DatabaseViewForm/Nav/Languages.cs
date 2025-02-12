namespace DatabaseViewForm.Nav;

public partial class Languages : UserControl
{
    private readonly BaseForm _parentForm;
    
    public Languages(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }
}