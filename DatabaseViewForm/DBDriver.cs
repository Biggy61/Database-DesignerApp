using System.Data;
using MySqlConnector;

namespace DatabaseViewForm;

public class DBDriver
{
    private static string ServerDomain = "vydb1.spsmb.cz";
    private static string Username = "lukas.pavlicek";
    private static string Password = "";
    private static string Database = "student_lukas.pavlicek_duolingo";

    private static string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password};Port=3306;";

    public MySqlException? ThrownException;

    public DBDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        MySqlConnection connection = GetConnection();
        try
        {
            connection.Open();
            string query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, connection);
            // execute reader
            var reader = command.ExecuteReader();
            // while reader.next
            while (reader.Read())
            {
                users.Add(new User(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2),
                    reader.GetDateTime(3)));
            }
        }
        catch (MySqlException ex)
        {
            ThrownException = ex;
        }

        // return list
        return users;
    }

    public void Insert(string name)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           "INSERT INTO users VALUES (NULL, @username, current_timestamp(), current_timestamp())",
                           connection))
                {
                    command.Parameters.AddWithValue("@username", name);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
   
    public void Delete(string ID)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           " DELETE FROM users WHERE id=@id",
                           connection))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        throw new Exception("User not found");
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
}