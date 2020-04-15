using System;
using Xunit;



namespace Palindrome.Tests
{
    public class Palindrome_or_not
    {
        [Fact]
        public void stars_palindrome_or_not()
        {
            var palindrome = "stars";
            var expectedResult = false;

            var palindromeChecker = new PalindromeChecker();

            var actualResult = palindromeChecker.Check(palindrome);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void oakak_palindrome_or_not()
        {
            var palindrome = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;

            var palindromeChecker = new PalindromeChecker();

            var actualResult = palindromeChecker.Check(palindrome);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void somemen_palindrome_or_not()
        {
            var palindrome = "Some men interpret nine memos";
            var expectedResult = true;

            var palindromeChecker = new PalindromeChecker();

            var actualResult = palindromeChecker.Check(palindrome);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
