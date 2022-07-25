using Microsoft.Data.Sqlite;
using MyNewApplication.Data;

namespace MyNewApplication.Service
{
    public class SQLiteService
    {
        public SqliteConnection sqliteConnection;

        public SQLiteService()
        {
            this.sqliteConnection = new SqliteConnection(@"Data Source=C:\Users\trist\source\repos\MyNewApplication\Messages.db;");
            
        }

        public void Init()
        {
            sqliteConnection.Open();
            var state = sqliteConnection.State;
            Console.WriteLine(state.ToString());
        }

        public void CreateContact(Contact contact)
        {
            SqliteCommand insertCommand = new ();
            insertCommand.Connection = sqliteConnection;
            insertCommand.CommandText =
                //"SELECT name FROM sqlite_master WHERE type='table' AND name='{table_name}'";
                $"INSERT INTO messagetable (name, email, message) VALUES (\"{contact.Name}\",\"{contact.Email}\",\"{contact.Message}\");";


            var res = insertCommand.ExecuteReader();
            while (res.Read())
            {
                Console.WriteLine(res.GetValue(0).ToString());
                res.NextResult();
            }
        }
    }
}
