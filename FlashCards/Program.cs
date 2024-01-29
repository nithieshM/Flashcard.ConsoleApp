using System.Configuration;
using Npgsql;

namespace FlashCards;

class Program
{
    internal static string connectionString = ConfigurationManager.ConnectionStrings["FlashCards"].ConnectionString;
    static void Main(string[] args)
    {
        
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        
        connection.Open();

        var tablecmd = connection.CreateCommand();
        tablecmd.CommandText = @"CREATE TABLE IF NOT EXISTS flashcards1 (
    Id SERIAL PRIMARY KEY,
    Date TIMESTAMP,
    test INTEGER
)";
        tablecmd.ExecuteNonQuery();
        connection.Close();
        Menu.MenuSelector();
    }
}