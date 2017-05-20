using NUnit.Framework;
using System;
namespace BinaryNumbers
{
    [TestFixture()]
    public class BinaryNumbersTests
    {
        private BinaryNumbers binaryNumbers;

		[OneTimeSetUp()]
		public void TestInitialize()
		{
			binaryNumbers = new BinaryNumbers();
		}

		[OneTimeTearDown()]
		public void TestCleanup()
		{
			binaryNumbers = null;
		}

		[Test]
		public void BinaryNumbers_returns_00000000000000000000000000000000_for_input_0()
		{
			var result = binaryNumbers.IntegerToBinary(0);
			Assert.AreEqual("0", result);
		}

		[Test]
		public void BinaryNumbers_returns_00000000000000000000000000000001_for_input_1()
		{
			var result = binaryNumbers.IntegerToBinary(1);
			Assert.AreEqual("1", result);
		}

		[Test]
		public void BinaryNumbers_returns_0000000000000000000010000000000_for_input_1024()
		{
			var result = binaryNumbers.IntegerToBinary(1024);
			Assert.AreEqual("10000000000", result);
		}

		[Test]
		public void BinaryNumbers_returns_00000000000000001111111111111111_for_input_65535()
		{
			var result = binaryNumbers.IntegerToBinary(65535);
			Assert.AreEqual("1111111111111111", result);
		}

		[Test]
		public void BinaryNumbers_returns_0000000000100000000000000000000_for_input_1048576()
		{
			var result = binaryNumbers.IntegerToBinary(1048576);
			Assert.AreEqual("100000000000000000000", result);
		}

		[Test]
		public void BinaryNumbers_returns_01010101010101010101010101010101_for_input_1431655765()
		{
			var result = binaryNumbers.IntegerToBinary(1431655765);
			Assert.AreEqual("1010101010101010101010101010101", result);
		}

		[Test]
		public void BinaryNumbers_returns_01111111111111111111111111111111_for_input_2147483647()
		{
			var result = binaryNumbers.IntegerToBinary(2147483647);
			Assert.AreEqual("1111111111111111111111111111111", result);
		}

		[Test]
		public void BinaryNumbers_returns_0_for_input_00000000000000000000000000000000()
		{
			var result = binaryNumbers.BinaryToInteger("0");
			Assert.AreEqual(0, result);
		}

		[Test]
		public void BinaryNumbers_returns_1_for_input_00000000000000000000000000000001()
		{
			var result = binaryNumbers.BinaryToInteger("1");
			Assert.AreEqual(1, result);
		}

		[Test]
		public void BinaryNumbers_returns_1024_for_input_0000000000000000000010000000000()
		{
			var result = binaryNumbers.BinaryToInteger("10000000000");
			Assert.AreEqual(1024, result);
		}

		[Test]
		public void BinaryNumbers_returns_65535_for_input_00000000000000001111111111111111()
		{
			var result = binaryNumbers.BinaryToInteger("1111111111111111");
			Assert.AreEqual(65535, result);
		}

		[Test]
		public void BinaryNumbers_returns_10485760_for_input_000000000010000000000000000000()
		{
			var result = binaryNumbers.BinaryToInteger("100000000000000000000");
			Assert.AreEqual(1048576, result);
		}

		[Test]
		public void BinaryNumbers_returns_1431655765_for_input_01010101010101010101010101010101()
		{
			var result = binaryNumbers.BinaryToInteger("1010101010101010101010101010101");
			Assert.AreEqual(1431655765, result);
		}

		[Test]
		public void BinaryNumbers_returns_2147483647_for_input_01111111111111111111111111111111()
		{
			var result = binaryNumbers.BinaryToInteger("1111111111111111111111111111111");
			Assert.AreEqual(2147483647, result);
		}
    }
}
