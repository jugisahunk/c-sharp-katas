﻿using NUnit.Framework;
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

        [Test()]
        public void IsPalindrome_returns_true_for_empty_string(){
            bool result = _testee.IsPalindrome(String.Empty);

            Assert.IsTrue(result);
        }
        
        [Test()]
        public void IsPalindrome_returns_false_for_ABCDE(){
            string testString = "ABCDE";

            bool result = _testee.IsPalindrome(testString);

            Assert.IsFalse(result);
        }

        [Test()]
        public void IsPalindrome_returns_true_for_ABBA(){
            //palindromes can be two, mirrored words e.g. AB BA
            string testString = "ABBA";

            bool result = _testee.IsPalindrome(testString);

            Assert.IsTrue(result);
        }

        [Test()]
        public void IsPalindrome_returns_true_for_racecar(){
			//palindromes can share a letter e.g. rac e car
			string testString = "racecar";

            bool result = _testee.IsPalindrome(testString);

            Assert.IsTrue(result);
        }

        [Test()]
        public void IsPalindrome_returns_true_for_Bob(){
            //case shouldn't matter
            string testString = "Bob";

            bool result = _testee.IsPalindrome(testString);

            Assert.IsTrue(result);
        }

        [Test()]
        public void IsPalindrome_returns_true_for_dammit_im_mad(){
            //non alpha characters shouldn't matter
            string testString = "Dammit, I'm mad!";

            bool result = _testee.IsPalindrome(testString);

            Assert.IsTrue(result);
        }
    }
}
