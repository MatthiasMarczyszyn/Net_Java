using NUnit.Framework;
using System.Collections.Generic;
using Lab1;

namespace Lab1test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var x = 0;
            for (var i = 0; i <= 10; i++)
            {
                RandomNumberGenerator rng = new RandomNumberGenerator(i);
                x = rng.nextInt(1, 29);
                Assert.IsTrue(x >= 1 && x <= 29);
                Assert.IsFalse(x > 29 && x < 1);
            }
        }
        [Test]
        public void Test2()
        {
            List<int> itemTest1 = new List<int>{0,1,2,3,4,5,6,7,8,9};
            List<int> valueTest1 = new List<int>{4,12,211,92,19,9,86,2,4,0};
            List<int> weightTest1 = new List<int>{5667,241,24,14,78,1,2,4123412,5,100};

            List<int> itemTest2 = new List<int>{0,1,2,3,4,5};
            List<int> valueTest2 = new List<int>{-37,420,-21,37,9,-11};
            List<int> weightTest2 = new List<int>{0,13,245698,-268,69,52}; 
            
            Assert.IsFalse(Program.KnapsackProblemNaive(10, itemTest1, valueTest1, weightTest1) == 10);       
            Assert.Equals(Program.KnapsackProblemNaive(20, itemTest2, valueTest2, weightTest2), 420);
            Assert.Greater(Program.KnapsackProblemNaive(1000, itemTest1, valueTest1, weightTest1) , 211);
        }
    }
}