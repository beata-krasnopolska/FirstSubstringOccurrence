using System;

namespace FirstSubstringOccurence
{
    class SubstringFinder
    {
        public int findFirstSubstringOccurrence( string longerText, string term)
        {
            int found = -1;
            int termIndex = 0;

            //quick check to protect the user from themselves
            if (String.IsNullOrEmpty(longerText) || string.IsNullOrEmpty(term))
                return -1;

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
