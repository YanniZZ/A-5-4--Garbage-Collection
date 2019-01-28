using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Advenced.Lesson_4
{
    public partial class Practice
    {
        /// <summary>
        /// AL4-P1/5.InstanceCounter. 
        /// AL4-P2/5.InstanceCounterWithHeapSize.
        /// AL4-P3/5.InstanceCounterWithGCCollect.
        /// </summary>
        public static void AL4_P1_P2_P3_5_InstanceCounter()
        {
            for (int i = 0; i<1500000;i++)
            {
                using (Counter number = new Counter())
                {
                    if (i % 50000 == 0)
                    {
                        Console.WriteLine("I равно: " + Counter.number);
                        Console.WriteLine(GC.GetTotalMemory(false));
                        GC.Collect();
                        Console.WriteLine("I равно: " + Counter.number);
                        Console.WriteLine(GC.GetTotalMemory(false));
                    }
                    //number.Dispose();
                }


            }
        }

        /// <summary>
        /// AL4-P4/5. IDisposable. 
        /// AL4-P4/5. IDisposableWithSuppress. 
        /// </summary>
        public static void AL4_P4_P5_5_InstanceCounter()
        {
        }
        
        public class Counter : IDisposable
        {
            public static int number;

            public Counter()
            {
                number++;
            }

            ~Counter()
            {
                //number--;
                Dispose();
            }
            public void Dispose()
            {
                GC.SuppressFinalize(this);
                number--;
            }
        }
    }
}
