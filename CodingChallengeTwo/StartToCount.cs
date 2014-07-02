namespace CodingChallengeTwo
{
    public class StartToCount
    {
        public void Counting(string line)
        {
            var len = line.Length;
            var checker = new IsTLSChecker()
            for (int j=0,j<len-2,j++)
            {
                var substring = line.Substring(j, 3);
                checker.IsTLS(substring);
            }
                

        }
    }
}