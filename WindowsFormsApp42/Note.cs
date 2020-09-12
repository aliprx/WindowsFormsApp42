using System;
using SQLite;
using System.IO;
namespace WindowsFormsApp42
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Text
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }
        public static string pathLitedb()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Note.litedb");
            return path;
        }
        public static string pathSqlite()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Note.sqlite");
            return path;
        }
    }
}