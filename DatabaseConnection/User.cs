namespace DatabaseConnection;

public class User
{
    public int Id;
    public string Username;
    public string Date_created;
    public string Date_modified;

    public User(int id, string username, string dateCreated, string dateModified)
    {
        Id = id;
        Username = username;
        Date_created = dateCreated;
        Date_modified = dateModified;
    }
}