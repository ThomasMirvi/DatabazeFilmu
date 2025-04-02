using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

public class Database
{
    private const string ConnectionString = "Data Source=filmy.db;Version=3;";

    public static void InitializeDatabase()
    {
        if (!File.Exists("filmy.db"))
        {
            SQLiteConnection.CreateFile("filmy.db");
        }

        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Filmy (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nazev TEXT NOT NULL,
                Rok INTEGER NOT NULL,
                Zanr TEXT NOT NULL,
                Rezie TEXT NOT NULL
            );";

            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }


    public static void AddFilm(string nazev, int rok, string zanr, string rezie, double hodnoceni)
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string insertQuery = "INSERT INTO Filmy (Nazev, Rok, Zanr, Rezie, Hodnoceni) VALUES (@nazev, @rok, @zanr, @rezie, @hodnoceni);";

            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@nazev", nazev);
                command.Parameters.AddWithValue("@rok", rok);
                command.Parameters.AddWithValue("@zanr", zanr);
                command.Parameters.AddWithValue("@rezie", rezie);
                command.Parameters.AddWithValue("@hodnoceni", hodnoceni);
                command.ExecuteNonQuery();
            }
        }
    }



    public static DataTable GetFilms()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Filmy;";
            using (var adapter = new SQLiteDataAdapter(selectQuery, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
    public static void DeleteFilm(int id)
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM Filmy WHERE Id = @id;";

            using (var command = new SQLiteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
    public static void UpdateFilm(int id, string nazev, int rok, string zanr, string rezie, double hodnoceni)
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string updateQuery = "UPDATE Filmy SET Nazev = @nazev, Rok = @rok, Zanr = @zanr, Rezie = @rezie, Hodnoceni = @hodnoceni WHERE Id = @id;";

            using (var command = new SQLiteCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@nazev", nazev);
                command.Parameters.AddWithValue("@rok", rok);
                command.Parameters.AddWithValue("@zanr", zanr);
                command.Parameters.AddWithValue("@rezie", rezie);
                command.Parameters.AddWithValue("@hodnoceni", hodnoceni);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }



}
