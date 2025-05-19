using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetLife.Core;
using System.Data.SQLite;



namespace VetLife.DataAccess
{
    public static class ConsultatieRepository
    {
        public static void Adauga(Consultatie c)
        {
            using (var conn = DatabaseHelper.GetConexiune())
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Consultatii (AnimalId,Data,Simptome,Diagnostic,Tratament) VALUES (@aid,@data,@s,@d,@t)", conn);
                cmd.Parameters.AddWithValue("@aid", c.AnimalId);
                cmd.Parameters.AddWithValue("@data", c.Data_consultatie);
                cmd.Parameters.AddWithValue("@s", c.Simptome);
                cmd.Parameters.AddWithValue("@d", c.Diagnostic);
                cmd.Parameters.AddWithValue("@t", c.Tratament);


                cmd.ExecuteNonQuery();

            }
        }

        public static List<Consultatie> GetAll()
        {
            var list = new List<Consultatie>();
            using (var conn = DatabaseHelper.GetConexiune())
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"SELECT c.*, a.Nume AS NumeAnimal FROM Consultatii c LEFT JOIN Animale a ON c.AnimalId=a.Id", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Consultatie
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            AnimalId = Convert.ToInt32(reader["AnimalId"]),
                            NumeAnimal = reader["NumeAnimal"].ToString(),
                            Data_consultatie = reader["Data_consultatie"].ToString(),
                            Simptome = reader["Simptome"].ToString(),
                            Diagnostic = reader["Diagnostic"].ToString(),
                            Tratament = reader["Tratament"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}