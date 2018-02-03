using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class OccurencesOfSubstringInAString
    {
        public static void Process()
        {
            char[] input = "XYZABABAABAEABFGHABAGAB".ToCharArray();
            char[] toFind = "ABA".ToCharArray();

            var matchingCount = NoOfOccurencesOfSubstringInAString(input, toFind);
        }

        private static int NoOfOccurencesOfSubstringInAString(char[] input, char[] toFind)
        {
            if (input.Length == 0 || toFind.Length == 0 || input.Length < toFind.Length)
            {
                return 0;
            }

            int toFindIndex = 0;
            int matchedCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == toFind[toFindIndex])
                {
                    //End of toFind string
                    if ((toFind.Length - 1) == toFindIndex)
                    {
                        matchedCount++;
                        toFindIndex = 0;
                    }
                    else
                    {
                        toFindIndex++;
                    }
                }
                else
                {
                    //Make toFindIndex to starting position
                    toFindIndex = 0;

                    //Check whether this char is equal to starting character
                    if (input[i] == toFind[toFindIndex])
                    {
                        toFindIndex++;
                    }
                }
            }

            return matchedCount;
        }
    }
}
