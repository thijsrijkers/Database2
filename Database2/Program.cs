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
            EntityFunction test = new EntityFunction();
            test.Entity_Test(1);
        }
    }
}
