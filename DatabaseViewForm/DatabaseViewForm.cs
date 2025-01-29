namespace DatabaseViewForm;

public partial class DatabaseViewForm : Form
{
    public DatabaseViewForm()
    {
        InitializeComponent();
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

    private void FetchButton_Click(object sender, EventArgs e)
    {
        DBDriver dbDriver = new DBDriver(PasswordTextBox.Text);
        List<User> users = dbDriver.GetUsers();
        Console.WriteLine(users.Count);
        PopulateListView(users);
    }
}