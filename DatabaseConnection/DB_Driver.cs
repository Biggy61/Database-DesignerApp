using MySqlConnector;

namespace DatabaseConnection;

static class DB_Driver
{
    private static string ServerDomain = "";
    private static string Username = "";
    private static string Password = Helpers.ReadSecret("Enter password: ");
    private static string Database = "";

    private static string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password};Port=3306;";
    public static List<User> ListOfPlayers;
    public static void DB_PrintUsers()
    {
        
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT * FROM users;", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"id: {reader.GetInt32(0)}");
                            Console.WriteLine($"username: {reader.GetString(1)}");
                            Console.WriteLine($"date-created: {reader.GetDateTime(2)}");
                            Console.WriteLine($"date-modified: {reader.GetDateTime(3)}");
                        }
                    }
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }


    public static void DB_InsertUser(string name)
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
            }
        }
    }

    public static void DB_PrintUserWithName(string name)
    {
        
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command =
                       new MySqlCommand("SELECT * FROM users WHERE name = '@username'",
                           connection))
                {
                    command.Parameters.AddWithValue("@username", name);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"id: {reader.GetInt32(0)}");
                            Console.WriteLine($"username: {reader.GetString(1)}");
                            Console.WriteLine($"date-created: {reader.GetDateTime(2)}");
                            Console.WriteLine($"date-modified: {reader.GetDateTime(3)}");
                        }
                    }
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}