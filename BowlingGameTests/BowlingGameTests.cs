using NUnit.Framework;
using System;
namespace BowlingGame
{

    [TestFixture()]
    public class BowlingGameTests
	{
		private BowlingGame _testee;

        [SetUp()]
		public void Setup()
		{
			_testee = new BowlingGame();
		}

        [TearDown()]
        public void Teardown(){
            _testee = null;
        }

        private void RollMany(int rolls, int pins)
        {
			for (int i = 0; i < rolls; i++)
			{
				_testee.Roll(pins);
			}
        }

        [Test()]
        public void Score_Gutter_Game()
        {
            int rolls = 20;

            RollMany(rolls, 0);

            int expectedResult = 0;

            int actualResult = _testee.Score();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test()]
        public void Score_All_Ones()
        {
            int rolls = 20;

            int expectedResult = 20;

            RollMany(rolls, 1);

            int actualResult = _testee.Score();

            Assert.AreEqual(expectedResult,actualResult);
        }

        [Test()]
        public void Score_One_Spare()
        {
            int rolls = 17;

            RollSpare();
            _testee.Roll(3);

            RollMany(rolls, 0);

            int actualResult = _testee.Score();

            Assert.AreEqual(16, actualResult);
        }

        [Test()]
        public void Score_One_Strike()
        {
            RollStrike();
            _testee.Roll(3);
            _testee.Roll(4);
            RollMany(16, 0);

            int actualResult = _testee.Score();

            Assert.AreEqual(24, actualResult);
        }

        [Test()]
        public void Score_Perfect_Game()
        {
            RollMany(12, 10);

            int actualResult = _testee.Score();

            Assert.AreEqual(300, actualResult);
        }

        private void RollStrike()
        {
            _testee.Roll(10);
        }

        private void RollSpare()
        {
            _testee.Roll(5);
            _testee.Roll(5);
        }
    }
}
