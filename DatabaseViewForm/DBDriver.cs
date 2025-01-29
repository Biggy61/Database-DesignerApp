using MySqlConnector;

namespace DatabaseViewForm;

public class DBDriver
{
    private static string ServerDomain = "vydb1.spsmb.cz";
    private static string Username = "stepan.zdansky";
    private static string Password = "";
    private static string Database = "student_stepan.zdansky_duolingo";

    private static string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password};Port=3306;";
    
    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        MySqlConnection connection = GetConnection();
        connection.Open();
        string query = "SELECT id, name, created, modified FROM users";
        MySqlCommand command = new MySqlCommand(query, connection);
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2),
                    reader.GetDateTime(3)));
            }
        }
        connection.Close();
        return users;
        
    }

    public DBDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}