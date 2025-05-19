using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetLife.Core;
using System.Data.SQLite;



namespace VetLife.DataAccess
{
    public static class AnimalRepository
    {
        public static void Adauga(Animal a)
        {
            using (var conn = DatabaseHelper.GetConexiune())
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Animale (Nume,Specie,Rasa,Varsta,Greutate,ProprietarId) VALUES (@nume,@specie,@rasa,@varsta,@greutate,@proprietarId)", conn);
                cmd.Parameters.AddWithValue("@nume", a.Nume);
                cmd.Parameters.AddWithValue("@specie", a.Specie);
                cmd.Parameters.AddWithValue("@rasa", a.Rasa);
                cmd.Parameters.AddWithValue("@varsta", a.Varsta);
                cmd.Parameters.AddWithValue("@greutate", a.Greutate);
                cmd.Parameters.AddWithValue("@proprietarId", a.ProprietarId);

                cmd.ExecuteNonQuery();

            }
        }

        public static List<Animal> GetAll()
        {
            var list = new List<Animal>();
            using (var conn = DatabaseHelper.GetConexiune())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT a.*, p.Nume as NumeProprietar FROM Animale a LEFT JOIN Proprietari p ON a.ProprietarId=p.Id", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Animal
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nume = reader["Nume"].ToString(),
                            Specie = reader["Specie"].ToString(),
                            Rasa = reader["Rasa"].ToString(),
                            Varsta = Convert.ToInt32(reader["Varsta"]),
                            Greutate = Convert.ToDouble(reader["Greutate"]),
                            ProprietarId = Convert.ToInt32(reader["ProprietarId"]),
                            NumeProprietar = reader["NumeProprietar"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}