using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodingChallengeTwo
{
    public class IsTLSChecker
    {
        public void IsTLS(string substring, Dictionary<string, int> dictionary)
        {
            var update = new UpdateDictionary();
            Regex rgx = new Regex("[a-zA-Z]{3}");
            if (rgx.IsMatch(substring))
            {
                update.Substring(substring, dictionary);
            }
        }
    }
}