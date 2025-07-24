using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Facturation_magasin {
    public partial class Produit
    {
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public string Categorie { get; set; }
        public string Code { get; set; }
    }

    public partial class ProduitDB
    {
        private string connection = "Data Source=produits.db;Version=3;";

        public ProduitDB()
        {
            using (var conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string tableCmd = @"CREATE TABLE IF NOT EXISTS Produits (
                                    Code TEXT NOT NULL ,
                                    Nom TEXT NOT NULL,
                                    Prix REAL NOT NULL,
                                    Categorie TEXT NOT NULL
                                );";
                SQLiteCommand cmd = new SQLiteCommand(tableCmd, conn);
                cmd.ExecuteNonQuery();
            }
        }
        public void AjouterProduit(Produit p)
        {
            using (var conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string insertCmd = "INSERT INTO Produits (Code, Nom, Prix, Categorie) VALUES (@Code, @Nom, @Prix, @Categorie)";
                SQLiteCommand cmd = new SQLiteCommand(insertCmd, conn);
                cmd.Parameters.AddWithValue("@Code", p.Code);
                cmd.Parameters.AddWithValue("@Nom", p.Nom);
                cmd.Parameters.AddWithValue("@Prix", p.Prix);
                cmd.Parameters.AddWithValue("@Categorie", p.Categorie);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Produit> LireProduits()
        {
            var produits = new List<Produit>();
            using (var conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string selectCmd = "SELECT * FROM Produits";
                SQLiteCommand cmd = new SQLiteCommand(selectCmd, conn);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produits.Add(new Produit
                        {
                            Code = reader["Code"].ToString(),
                            Nom = reader["Nom"].ToString(),
                            Prix = Convert.ToDecimal(reader["Prix"]),
                            Categorie = reader["Categorie"].ToString()
                        });
                    }
                }
            }
            return produits;
        }

        public void ModifierProduit(Produit p)
        {
            using (var conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string updateCmd = "UPDATE Produits SET Nom=@Nom, Prix=@Prix, Categorie=@Categorie WHERE Code=@Code";
                SQLiteCommand cmd = new SQLiteCommand(updateCmd, conn);
                cmd.Parameters.AddWithValue("@Nom", p.Nom);
                cmd.Parameters.AddWithValue("@Prix", p.Prix);
                cmd.Parameters.AddWithValue("@Categorie", p.Categorie);
                cmd.Parameters.AddWithValue("@Code", p.Code);
                cmd.ExecuteNonQuery();
            }
        }

        public void SupprimerProduit(string code)
        {
            using (var conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string deleteCmd = "DELETE FROM Produits WHERE Code=@Code";
                SQLiteCommand cmd = new SQLiteCommand(deleteCmd, conn);
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.ExecuteNonQuery();
            }
        }
    }
}