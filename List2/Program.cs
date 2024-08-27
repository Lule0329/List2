using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] intersectionSet1 = { "a", "b", "s", "d", "e" };
            string[] intersectionSet2 = { "h", "d", "w", "s", "a" };
            Console.WriteLine("Demonstration av Intersection:");
            Console.WriteLine("Set 1: " + string.Join(",", intersectionSet1));
            Console.WriteLine("Set 2: " + string.Join(",", intersectionSet2));
            List<string> intersectionResult = Intersection(intersectionSet1, intersectionSet2);
            Console.WriteLine("Resultat: " + string.Join(",", intersectionResult));
            Console.WriteLine();

        }

        public static List<string> Intersection(string[] set1, string[] set2)
        {
            List<string> result = new List<string>();
            
            for (int i = 0; i < set1.Length; i++)
            {
                for (int a = 0; a < set2.Length; a++)
                {
                    if (set1[i] == set2[a])
                    {
                        result.Add(set1[i].ToString());
                    }
                }
            }

            return result;
        }
    }
}
