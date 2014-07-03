using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodingChallengeTwo
{
    public class LookThroughDocument
    {
        public void StartLooking(Dictionary<string, int>  dictionary)
        {
            string line;
            // Read the file and display it line by line.
            var file = new StreamReader("tls.txt");
            var linecount = new StartToCount();


            while ((line = file.ReadLine()) != null)
            {
                linecount.Counting(line, dictionary);

            }
            file.Close();
            // Suspend the screen.
            /*foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine("TLS = {0}, frequency = {1}", kvp.Key, kvp.Value);
            }
            var readLine = Console.ReadLine();*/
        }
    }
}