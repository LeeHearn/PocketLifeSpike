using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace RateCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string sqConnectionString = "DataSource=C:\\gitRepository\\PocketLife\\RateCalculator\\RateCalculator.s3db; Version=3;";

            SQLiteConnection myConn = new SQLiteConnection(sqConnectionString);
            string myInsertQuery = "SELECT * FROM Person";
            SQLiteCommand sqCommand = new SQLiteCommand(myInsertQuery);
            sqCommand.Connection = myConn;
            myConn.Open();
            try
            {
                sqCommand.ExecuteNonQuery();
            }
            finally
            {
                myConn.Close();
            } 

            var table = new Models.Person();

            // Load all the distinct client records from the database.
            var persons = table.All();

            foreach (var person in persons)
            {
                Console.WriteLine("FirstName: {0}      MiddleName: {1}      LastName: {2}",
                    person.FirstName, person.MiddleName, person.LastName);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Person());
        }
    }
}
