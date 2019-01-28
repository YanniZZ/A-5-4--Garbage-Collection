using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advenced.Lesson_4
{
    public partial class Lesson
    {
        public static string StaticField;

        public static void ValueTypeLifeCycleExample()
        {
            var number = 1;
            var number2 = number;

            ValueTypeLifyCycleMethod();
            //Doing some algorithm
        }

        public static void RefTypeLifeCycleExample()
        {
            var dictionary = RefTypeLifyCycleMethod();
            //Doing some very long algorithm
        }

        public static void WeakReferenceLifeCycleExample()
        {
            var cache = new Dictionary<int, WeakReference>();
            for (int i = 0; i < 20; i++)
            {
                cache.Add(i, new WeakReference(new List<string> { "abc" }));
            }
        }

        private static void ValueTypeLifyCycleMethod()
        {
            var localNumber = 3;
            //Doing some algorithm
        }

        private static Dictionary<int, string> RefTypeLifyCycleMethod()
        {
            var localNumber = 3;

            var localDictionary =
                new Dictionary<int, string> {
                    { 234, "Petya" },
                    { 123, "Vasya" }
                };

            var localDictionary2 =
                new Dictionary<int, string> {
                    { 345, "Olga" },
                    { 345, "Dash" }
                };

            return localDictionary2;
        }
    }
}
