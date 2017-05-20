using NUnit.Framework;
using System;
namespace Palindromes
{
    [TestFixture()]
    public class PalindromeTests
    {
        private Palindrome _testee;

        [OneTimeSetUp]
        public void SetUp(){
            _testee = new Palindrome();
        }

        [OneTimeTearDown]
        public void TearDown(){
            _testee = null;
        }

        [Test()]
        public void IsPalindrome_returns_true_for_null()
        {
            bool result = _testee.IsPalindrome(null);

            Assert.IsTrue(result);
        }
    }
}
