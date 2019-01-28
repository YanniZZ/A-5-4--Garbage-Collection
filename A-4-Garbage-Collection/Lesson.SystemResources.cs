using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Advenced.Lesson_4
{
    public partial class Lesson
    {
        public static void SystemResourcesExample1()
        {
            var fs = new FileStream("D:\\csharpfile.txt", FileMode.Create);
            fs.Close();
        }

        public static void SystemResourcesExample2()
        {
            var myRequest = WebRequest.Create("http://www.contoso.com");
            var myResponse = myRequest.GetResponse();
            myResponse.Close();
        }

        public static void SystemResourcesExample3(string connectionString)
        {
            var con = new SqlConnection(connectionString);
            con.Open();
            //do some db requests
            con.Close();

        }

    }
}
