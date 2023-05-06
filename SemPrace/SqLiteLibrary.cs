using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemPrace
{
    public class SqLiteLibrary
    {
        public static string path = "data_tb.db";
        public static string cs = @"URI=file:" + Application.StartupPath + "\\data_tb.db";

        public static void createDB()
        {
            if (!System.IO.File.Exists(SqLiteLibrary.path))
            {
                SQLiteConnection.CreateFile(SqLiteLibrary.path);
            }
        }

        public static void createTable(string sql)
        {
            using (var sqlite = new SQLiteConnection(@"Data Source=" + SqLiteLibrary.path))
            {
                sqlite.Open();
                SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                command.ExecuteNonQuery();
            }
        }
    }
}
