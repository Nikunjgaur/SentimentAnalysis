using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SentimentAnalysis
{
    public class LogEntry
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string ModelName { get; set; }
        public int NgPartCount { get; set; }
    }
    public class Database
    {
        static string tableName = "buttonreport";
        public static void CreateTableIfDoesNotExist(string schema = "public")
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT EXISTS (
                    SELECT 1
                    FROM information_schema.tables
                    WHERE table_name = @tableName
                )";

                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);
                    bool tableExists = (bool)command.ExecuteScalar();

                    if (!tableExists)
                    {
                        string createTableQuery = $@"
                        CREATE TABLE {schema}.{tableName}
                        (
                            _date date,
                            _time time without time zone,
                            ngpartcount int,
                            finalresult varchar
                        )";

                        using (NpgsqlCommand createTableCommand = new NpgsqlCommand(createTableQuery, conn))
                        {
                            createTableCommand.ExecuteNonQuery();
                            Console.WriteLine($"Table '{tableName}' created.");
                        }
                    }
                }
            }
        }
        public static void InsertData(LogEntry logEntry)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();

                string insertQuery = $@"
                INSERT INTO {tableName} (_date, _time, modelname, ngpartcount)
                VALUES (@Date, @Time, @Modelname,@NgPartCount)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Date", logEntry.Date);
                    command.Parameters.AddWithValue("@Time", logEntry.Time);
                    command.Parameters.AddWithValue("@Modelname", logEntry.ModelName);
                    command.Parameters.AddWithValue("@NgPartCount", logEntry.NgPartCount);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Data inserted into the table.");
                }
            }
        }
        static void DisplayData()
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();

                string selectQuery = $@"
                SELECT _date, _time, ngpartcount, finalresult
                FROM {tableName}";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Data in the table:");
                        while (reader.Read())
                        {
                            DateTime date = reader.GetDateTime(0);
                            TimeSpan time = reader.GetTimeSpan(1);
                            int ngPartCount = reader.GetInt32(2);
                            string finalResult = reader.GetString(3);

                            Console.WriteLine($"Date: {date}, Time: {time}, NgPartCount: {ngPartCount}, FinalResult: {finalResult}");
                        }
                    }
                }
            }
        }

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server = localhost; Port = 5432; user Id = postgres; password = 1234; Database = postgres;");
        }
    }


}