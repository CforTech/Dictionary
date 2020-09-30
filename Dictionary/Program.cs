using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            
            /*
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(4, "four");
            Console.WriteLine(dict.Count);

            Console.ReadKey();
       */

            Dictionary<int, string> dict = new Dictionary<int, string>()
              {
                 {1,"One"},
                 {2, "Two"},
                 {3,"Three"},
                 //{4, "Four"}
              };                                              

            string result;

            if (dict.TryGetValue(4, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could not find the specified key.");
            }


            Console.ReadKey();
        }
    }
}
