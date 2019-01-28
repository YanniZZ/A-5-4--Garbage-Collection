using System;
using System.IO;

namespace Advenced.Lesson_4
{
    public partial class Lesson
    {

        public static void SystemResourceWithoutUsing()
        {
            StreamWriter sw = new StreamWriter("d://test.txt");
            sw.Write("Some text");
            //sw.Close();
            sw.Dispose();
        }

        public static void SystemResourceWithoutExceptionHandling()
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("d://test.txt");
                sw.Write("Some text");
            }            
            finally
            {
                sw?.Dispose();
            }
        }

        public static void SystemResourceWithUsing()
        {
            using (StreamWriter sw = new StreamWriter("d://test.txt"))
            {
                sw.Write("Some text");
            }                
        }
    }
}
