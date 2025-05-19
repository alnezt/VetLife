using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace VetLife.DataAccess
{
    public class DatabaseHelper
    {
        private static readonly string caleDB = @"C:\\Users\\maria\\Desktop\\ip-proiect\\clinica.db";
        private static readonly string conexiune = $"Data Source={caleDB};Version=3";
        public static SQLiteConnection GetConexiune()
        {
            return new SQLiteConnection(conexiune);
        }
    }
}
