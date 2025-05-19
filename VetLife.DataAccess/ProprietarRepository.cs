using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetLife.Core;
using System.Data.SQLite;



namespace VetLife.DataAccess
{
    public static class ProprietarRepository
    {
        public static void Adauga(Proprietar p)
        {
            using (var conn = DatabaseHelper.GetConexiune())
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Proprietari (Nume,Telefon,Email) VALUES (@nume,@tel,@email)", conn);
                cmd.Parameters.AddWithValue("@nume",p.Nume);
                cmd.Parameters.AddWithValue("@tel", p.Telefon);
                cmd.Parameters.AddWithValue("@email", p.Email);
                cmd.ExecuteNonQuery();

            }
        }

        public static List<Proprietar> GetAll()
        {
            var list = new List<Proprietar>();
            using (var conn = DatabaseHelper.GetConexiune())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Proprietari", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Proprietar
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nume = reader["Nume"].ToString(),
                            Telefon = reader["Telefon"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}