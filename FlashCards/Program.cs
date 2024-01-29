using Npgsql;

namespace FlashCards;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Aedwasd*2001;Database=postgres";
        NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        
        connection.Open();

        var tablecmd = connection.CreateCommand();
        tablecmd.CommandText = @"CREATE TABLE IF NOT EXISTS flashcards (
    Id SERIAL PRIMARY KEY,
    Date TIMESTAMP
)";
        tablecmd.ExecuteNonQuery();
        connection.Close();
        Menu.MenuSelector();
    }
}