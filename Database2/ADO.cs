using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Database2
{
    class ADO
    {
        public void ADO_Test(int counter)
        {
            string DBconn = @"Server=OBSIDIANGTX1070\SQLEXPRESS; Database=Databases2_Databases; Integrated Security=true";

            using (var conn = new SqlConnection(DBconn))
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                conn.Open();

                for (int i = 0; i < counter; i++)
                {
                    string insert = "INSERT INTO [User] (Name, Password, Email) VALUES ('TestUser', 'OE2SpwzyH', 'aaberhart0@wordpress.org');";

                    SqlCommand command = new SqlCommand(insert, conn);

                    SqlDataReader reader = command.ExecuteReader();

                    reader.Close();
                }

                string update = "UPDATE [User] SET Name = 'TestUserReplaced' WHERE Name = 'TestUser';";

                string select = "SELECT * FROM [User] WHERE Name = 'TestUserReplaced';";

                string delete = "DELETE FROM [User] WHERE Name = 'TestUserReplaced';";

                SqlCommand command2 = new SqlCommand(update, conn);

                SqlDataReader reader2 = command2.ExecuteReader();

                reader2.Close();

                SqlCommand command3 = new SqlCommand(select, conn);

                SqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {
                    Console.WriteLine("{0} {1} {2} {3}", reader3[0], reader3[1], reader3[2], reader3[3]);
                }
                reader3.Close();

                SqlCommand command4 = new SqlCommand(delete, conn);

                SqlDataReader reader4 = command4.ExecuteReader();

                reader4.Close();

                conn.Close();

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;

                Console.WriteLine(ts);
            }
        }
    }
}
