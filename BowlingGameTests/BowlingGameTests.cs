using NUnit.Framework;
using System;
namespace BowlingGame
{

    [TestFixture()]
    public class BowlingGameTests
	{
		private BowlingGame _testee;

		[OneTimeSetUp]
		public void Setup()
		{
			_testee = new BowlingGame();
		}

        [OneTimeTearDown()]
        public void Teardown(){
            _testee = null;
        }

        [Test()]
        public void Score_Gutter_Game(){
            for (int i = 0; i < 20; i++){
                _testee.Roll(0);
            }

            int expectedResult = 0;

            int actualResult = _testee.Score();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
