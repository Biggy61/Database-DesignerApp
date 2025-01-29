namespace DatabaseViewForm;

public class User
{
    public int Id;
    public string Username;
    public DateTime Date_created;
    public DateTime Date_modified;


    public User(int id, string username, DateTime dateCreated, DateTime dateModified)
    {
        Id = id;
        Username = username;
        Date_created = dateCreated;
        Date_modified = dateModified;
    }
}