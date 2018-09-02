using System;

namespace FirstSubstringOccurence
{
    class SubstringFinder
    {
        public int findFirstSubstringOccurrence( string longerText, string term)
        {
            var found = -1;
            var termIndex = 0;
            var i = 0;

            //quick check to protect the user from themselves
            if (String.IsNullOrEmpty(longerText) || string.IsNullOrEmpty(term))
                return -1;
            
            foreach (var letter in longerText)
            {
                if (letter == term[termIndex])
                {
                    if (termIndex == 0)
                        found = i;
                    termIndex++;
                    if (termIndex >= term.Length)
                        return found;
                }
                else
                {
                    termIndex = 0;
                    if (found >= 0)
                        i = found;
                    found = -1;
                }
                i++;
            }

            for (int longerTextIndex = 0; longerTextIndex < longerText.Length; longerTextIndex++)
            {
                if (term[termIndex] == longerText[longerTextIndex])
                {
                    if (termIndex == 0)
                        found = longerTextIndex;
                    termIndex++;
                    if (termIndex >= term.Length)
                        return found;
                }
                else
                {
                    termIndex = 0;
                    if (found >= 0)
                        longerTextIndex = found;
                    found = -1;
                }
            }
            return -1;
        }
    }
}
