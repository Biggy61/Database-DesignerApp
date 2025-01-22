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

    public DBDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection();
    }
}