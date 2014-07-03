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
            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            var looking = new LookThroughDocument();
            looking.StartLooking(frequencies);
            /*foreach (KeyValuePair<string, int> kvp in frequencies)
            {
                Console.WriteLine("TLS = {0}, Frequency = {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();*/
            Console.WriteLine("Enter frequency you would like to view:");
            int frequency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(frequency + 1);
            Console.ReadLine();
            var findtls = new FindFrequencies();
            findtls.PrintTLS(frequency, frequencies);
            Console.ReadLine();

            }
    }

    public class FindFrequencies
    {
        public void PrintTLS(int frequency, Dictionary<string, int> frequencies)
        {
            throw new NotImplementedException();
        }
    }
}
