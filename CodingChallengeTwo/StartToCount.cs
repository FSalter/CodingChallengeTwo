using System;
using System.Collections.Generic;

namespace CodingChallengeTwo
{
    public class StartToCount
    {
        public void Counting(string line, Dictionary<string, int> dictionary)
        {
            var len = line.Length;
            var checker = new IsTLSChecker();
            for (var j=0;j<len-2;j++)
            {
                var substring = line.Substring(j, 3);
                checker.IsTLS(substring, dictionary);
            }
            
        }
    }
}