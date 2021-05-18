using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ResestingHouseMustHave4Seeds()
        {
            //ARRANGE:
            House h = new House (0,0);
            for (int i = 0; i < 21; i++)
            {
                h.AddSeedInPot(new Seed());
            }
            // ACT
            h.ResetHouse();
            //ASSERT:
            Assert.AreEqual(4,h.GetCount(),"Houses that have been reset must have 4 seeds in them");
        }

        [Test]
        public void AddSeedtoScoreHouseShoulCallAddSeed()
        {
            //ARRANGE:
            Player p1 = new Player("Foo");
            Player p2 = new Player("Bar");
            Board b = new Board(p1,p2);


            //ACT

            //ASSERT
        }
    }
}