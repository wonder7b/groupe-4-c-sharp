using System;
using System.Data.SQLite;

namespace Facturation_magasin
{
    public partial class Utilisateur
    {
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
    }

    public partial class UtilisateurDB
    {
        private string connection = "Data Source=utilisateurs.db;Version=3;";

        public UtilisateurDB()
        {
            using (var conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string createTable = @"
                CREATE TABLE IF NOT EXISTS Utilisateurs (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nom TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    Adresse TEXT NOT NULL,
                    Telephone TEXT NOT NULL
                );";
                SQLiteCommand cmd = new SQLiteCommand(createTable, conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void Inserer(Utilisateur u)
        {
            using (var conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string insertCmd = @"
                INSERT INTO Utilisateurs (Nom, Email, Adresse, Telephone)
                VALUES (@Nom, @Email, @Adresse, @Telephone)";
                SQLiteCommand cmd = new SQLiteCommand(insertCmd, conn);
                cmd.Parameters.AddWithValue("@Nom", u.Nom);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Adresse", u.Adresse);
                cmd.Parameters.AddWithValue("@Telephone", u.Telephone);
                cmd.ExecuteNonQuery();
            }
        }
        public bool Verifier()
        {
            using (var conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string countCmd = "SELECT COUNT(*) FROM Utilisateurs";
                SQLiteCommand cmd = new SQLiteCommand(countCmd, conn);
                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
