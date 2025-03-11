using System.Text.RegularExpressions;

namespace DatabaseViewForm.Nav;

public partial class Languages : UserControl
{
    private readonly BaseForm _parentForm;

    public Languages(BaseForm parentForm)
    {
        _parentForm = parentForm;
        InitializeComponent();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        _parentForm.SwitchLanguage(BaseForm.Forms.Navigation);
    }

    private void PopulateListView(List<Language> languages)
    {
        UserListView.Items.Clear();
        foreach (var language in languages)
        {
            ListViewItem item = new ListViewItem();
            item.Text = language.Id.ToString();
            item.SubItems.Add(language.Username);
            item.SubItems.Add(language.Date_created.ToString());
            item.SubItems.Add(language.Date_modified.ToString());
            UserListView.Items.Add(item);
        }
    }

    private void LoadLanguages()
    {
        List<Language> languages = DBDriver.GetLanguages();
        if (DBDriver.ThrownException is not null)
        {
            //ErrorLabel.Text = _parentForm._dbDriver.ThrownException.Message;
            DBDriver.ThrownException = null;
            _parentForm._dbDriver = null;
        }
        else
        {
            PopulateListView(languages);
        }
    }

    private void FetchButton_Click(object sender, EventArgs e)
    {
        LoadLanguages();
    }

    private void InsertLanguages_Click(object sender, EventArgs e)
    {
        if (InsertLanguages_TextBox.Text == "")
        {
            ErrorLabel.Text = "you must enter the name";
        }
        else
        {
            DBDriver.InsertLanguage(InsertLanguages_TextBox.Text);
            InsertLanguages_TextBox.Text = "";
            LoadLanguages();
        }
    }

    private void InsertLanguages_TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (InsertLanguages_TextBox.Text == "")
        {
            ErrorLabel.Text = "you must enter the name";
        }
        else
        {
            if (e.KeyCode == Keys.Enter)
            {
                DBDriver.InsertLanguage((InsertLanguages_TextBox.Text));
                InsertLanguages_TextBox.Text = "";
                LoadLanguages();
            }
        }
    }

    private void DeleteLanguages_Button_Click(object sender, EventArgs e)
    {
        deleteLanguage();
    }

    private void DeleteLanguages_TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            deleteLanguage();
        }
    }

    private void deleteLanguage()
    {
        if (!Regex.IsMatch(DeleteLanguages_TextBox.Text, @"^(\s*[0-9]+\s*,?\s*)+$"))
        {
            ErrorLabel.Text = "Please enter a valid number";
        }
        else
        {
            var ids = DeleteLanguages_TextBox.Text.Split(',');
            foreach (var id in ids)
            {
                id.Trim();

                try
                {
                    DBDriver.DeleteLanguages(id);
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = ex.Message;
                }
            }
        }

        DeleteLanguages_TextBox.Text = "";
        LoadLanguages();
    }
}