using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodingChallengeTwo
{
    public class Program
    {
        public static void Main()
        {
            var frequencies = new Dictionary<string, int>();
            var looking = new LookThroughDocument();
            looking.StartLooking(frequencies);

            /*foreach (KeyValuePair<string, int> kvp in frequencies)
            {
                Console.WriteLine("TLS = {0}, Frequency = {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();*/

            Console.Write("Enter frequency you would like to view: ");
            var frequency = Convert.ToInt32(Console.ReadLine());
            var findtls = new FindFrequencies();
            findtls.PrintTLS(frequency, frequencies);
            Console.ReadLine();

            }
    }
}
