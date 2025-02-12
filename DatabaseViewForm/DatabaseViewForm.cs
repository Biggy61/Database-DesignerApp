using System.Text.RegularExpressions;

namespace DatabaseViewForm;

public partial class DatabaseViewForm : Form
{
    public DBDriver _dbDriver;

    public DatabaseViewForm()
    {
        InitializeComponent();
        this.ActiveControl = FetchButton;
        FetchButton.Focus();
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

    private void Login()
    {
        ErrorLabel.Text = "";
        if (_dbDriver is null)
        {
            _dbDriver = new DBDriver(PasswordTextBox.Text);
        }

        PasswordTextBox.Text = "";
    }

    private void LoadUsers()
    {
        List<User> users = _dbDriver.GetUsers();
        if (_dbDriver.ThrownException is not null)
        {
            ErrorLabel.Text = _dbDriver.ThrownException.Message;
            _dbDriver.ThrownException = null;
            _dbDriver = null;
        }
        else
        {
            PopulateListView(users);
        }
    }

    private void FetchButton_Click(object sender, EventArgs e)
    {
        Login();
        LoadUsers();
    }

    private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Login();
            LoadUsers();
        }
    }

    private void Insert_Button_Click(object sender, EventArgs e)
    {
        _dbDriver.Insert(Insert_TextBox.Text);
        Insert_TextBox.Text = "";
        LoadUsers();
    }

    private void Insert_TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            _dbDriver.Insert((Insert_TextBox.Text));
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
                    _dbDriver.Delete(id);
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