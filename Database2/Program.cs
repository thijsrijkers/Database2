using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Database2
{
    class Program
    {
        static void Main(string[] args)
        {
            ADO adoTest = new ADO();
            adoTest.ADO_Test(10);

            EntityFunction entityTest = new EntityFunction();
            entityTest.Entity_Test(10);

            NoSQL NoSQLtest = new NoSQL();
            NoSQLtest.NOSQL_Test(10);

            Console.ReadKey(true);
        }
    }
}
