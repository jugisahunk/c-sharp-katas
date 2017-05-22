using System;
using System.Text.RegularExpressions;
namespace Palindromes
{
    public class Palindrome
    {
        public Palindrome()
        {
	}

<<<<<<< Updated upstream
	public bool IsPalindrome(string s)
	{
            throw new NotImplementedException();
	}
=======
		public bool IsPalindrome(string s)
		{
            if (s is null || s == String.Empty)
                return true;

            string cleaned = Regex.Replace(s, "[^a-zA-Z]", String.Empty);
            string lowered = cleaned.ToLower();
            char[] chars = lowered.ToCharArray();
            Array.Reverse(chars);
            string reversedString = new string(chars);

            return reversedString == lowered;
		}
>>>>>>> Stashed changes
    }
}
