using System.Text.RegularExpressions;

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


    private void UserListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
    private void PopulateListView(List<User> users)
    {
        UserListView.Items.Clear();
        foreach (var user in users)
        {
            ListViewItem item = new ListViewItem();
            item.Text = user.Id.ToString();
            item.SubItems.Add(user.Username);
            item.SubItems.Add(user.Date_created.ToString());
            item.SubItems.Add(user.Date_modified.ToString());
            UserListView.Items.Add(item);
        }
    }

    private void LoadUsers()
    {
        List<User> users = DBDriver.GetUsers();
        if (DBDriver.ThrownException is not null)
        {
            //ErrorLabel.Text = _parentForm._dbDriver.ThrownException.Message;
            DBDriver.ThrownException = null;
            _parentForm._dbDriver = null;
        }
        else
        {
            PopulateListView(users);
        }
    }

    private void FetchButton_Click(object sender, EventArgs e)
    {
        LoadUsers();
    }
    
    private void Insert_Button_Click(object sender, EventArgs e)
    {
        DBDriver.Insert(Insert_TextBox.Text);
        Insert_TextBox.Text = "";
        LoadUsers();
    }

    private void Insert_TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            DBDriver.Insert((Insert_TextBox.Text));
            Insert_TextBox.Text = "";
            LoadUsers();
        }
    }

    private void Delete_Button_Click(object sender, EventArgs e)
    {
        deleteUser();
    }

    private void Delete_TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            deleteUser();
        }
    }

    private void deleteUser()
    {
        if (!Regex.IsMatch(Delete_TextBox.Text, @"^(\s*[0-9]+\s*,?\s*)+$"))
        {
            ErrorLabel.Text = "Please enter a valid number";
        }
        else
        {
            var ids = Delete_TextBox.Text.Split(',');
            foreach (var id in ids)
            {
                id.Trim();

                try
                {
                    DBDriver.Delete(id);
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = ex.Message;
                }
            }
        }
            
        Delete_TextBox.Text = "";
        LoadUsers();
    }

    
}