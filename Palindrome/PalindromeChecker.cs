using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome
{
    public class PalindromeChecker
    {
        public bool Check(string palindrome)
        {

            var palindromeClean = Regex.Replace(palindrome, "[^A-Za-z0-9]", "");
            var first = palindromeClean.Substring(0, palindromeClean.Length / 2).ToLower();
            char[] arr = palindromeClean.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            var second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}