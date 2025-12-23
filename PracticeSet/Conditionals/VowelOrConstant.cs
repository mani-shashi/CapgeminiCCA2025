using System;

namespace PracticeQuestions
{
    public class VowelChecker
    {
        public bool IsVowel(char c)
        {
            switch (char.ToLower(c))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                return true;

                default:
                return false; 
            }
        }
    }
}