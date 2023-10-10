using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest
{
    public class WordRearrange
    {
        public string EligibleForNextRound(string word1, string word2)        
        {           
            char[] charArray1 = word1.ToLower().ToCharArray();
            char[] charArray2 = word2.ToLower().ToCharArray();
            
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            
            if (new string(charArray1) == new string(charArray2))
            {
                return "YES";
            }
            else
            {
                return "NO";
            }

        }
    }
}
