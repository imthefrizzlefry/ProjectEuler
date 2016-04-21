using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ProjectEulerTests
{
    [TestClass]
    public class ProjectEulerTests
    {
        #region Project Euler 001 Tests

        [TestMethod]
        [TestCategory("ProjectEuler001")]
        public void ProjectEuler001Test1()
        {
            List<int> testInput = new List<int>
            {
                2, 10, 100
            };

            List<long> expectedOutput = new List<long>
            {
                23, 2318
            };

            List<long> actualOutput = ProjectEuler.Challenge001MultiplesOfThreeAndFive.GetMultiplesLessThanN(testInput);

            for (int testValue = 0; testValue < expectedOutput.Count; testValue++)
            {
                Assert.AreEqual(expectedOutput[testValue], actualOutput[testValue], string.Format("test value {0} is incorrect", testValue));
            }

        }

        [TestMethod]
        [TestCategory("ProjectEuler001")]
        public void ProjectEuler001Test2()
        {
            List<int> testInput = new List<int>
            {
                10, 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000
            };

            List<long> expectedOutput = new List<long>
            {
                0, 23, 2318, 233168, 23331668,
                2333316668, 233333166668, 23333331666668, 2333333316666668, 233333333166666668
            };

            List<long> actualOutput = ProjectEuler.Challenge001MultiplesOfThreeAndFive.GetMultiplesLessThanN(testInput);

            for (int testValue = 0; testValue < expectedOutput.Count; testValue++)
            {
                Assert.AreEqual(expectedOutput[testValue], actualOutput[testValue], string.Format("test value {0} is incorrect", testValue));
            }

        }
        #endregion



        #region Project Euler 130 Tests
        [TestMethod]
        [TestCategory("ProjectEuler130")]
        public void ProjectEuler130Test0()
        {
            int LeftValue = 91;
            int RightValue = 14701;

            List<int> expectedOutput = new List<int>
            {
                91, 259, 451, 481, 703,
                1729, 2821, 2981, 3367, 4141,
                4187, 5461, 6533, 6541, 6601,
                7471, 7777, 8149, 8401, 8911,
                10001, 11111, 12403, 13981, 14701
            };

            List<int> actualOutput = ProjectEuler.Challenge130CompositesWithPrimeRepunitProperty.compositeInterval(LeftValue, RightValue);

            Assert.AreEqual(expectedOutput.Count, actualOutput.Count, "An unexpected number of items was returned!");

            for (int testValue = 0; testValue < expectedOutput.Count; testValue++)
            {
                Assert.AreEqual(expectedOutput[testValue], actualOutput[testValue], string.Format("test value {0} is incorrect", testValue));
            }
        }

        [TestMethod]
        [TestCategory("ProjectEuler130")]
        public void ProjectEuler130Test1()
        {
            int LeftValue = 2;
            int RightValue = 1000;

            List<int> expectedOutput = new List<int>
            {
                91,
                259,
                451,
                481,
                703
            };

            List<int> actualOutput = ProjectEuler.Challenge130CompositesWithPrimeRepunitProperty.compositeInterval(LeftValue, RightValue);

            Assert.AreEqual(expectedOutput.Count, actualOutput.Count, "An unexpected number of items was returned!");

            for (int testValue = 0; testValue < expectedOutput.Count; testValue++)
            {
                Assert.AreEqual(expectedOutput[testValue], actualOutput[testValue], string.Format("test value {0} is incorrect", testValue));
            }
        }

        [TestMethod]
        [TestCategory("ProjectEuler130")]
        public void ProjectEuler130Test2()
        {
            int LeftValue = 2;
            int RightValue = 10000;

            List<int> expectedOutput = new List<int>
            {
                91, 259, 451, 481, 703, 1729, 2821, 2981, 3367, 4141, 4187, 5461, 6533, 6541, 6601, 7471, 7777, 8149, 8401, 8911
            };

            List<int> actualOutput = ProjectEuler.Challenge130CompositesWithPrimeRepunitProperty.compositeInterval(LeftValue, RightValue);

            Assert.AreEqual(expectedOutput.Count, actualOutput.Count, "An unexpected number of items was returned!");

            for (int testValue = 0; testValue < expectedOutput.Count; testValue++)
            {
                Assert.AreEqual(expectedOutput[testValue], actualOutput[testValue], string.Format("test value {0} is incorrect", testValue));
            }
        }

        [TestMethod]
        [TestCategory("ProjectEuler130")]
        public void ProjectEuler130Test3()
        {
            int LeftValue = 2;
            int RightValue = 150000;

            List<int> expectedOutput = new List<int>
            {
                91, 259, 451, 481, 703, 1729, 2821, 2981, 3367, 4141, 4187, 5461, 6533, 6541, 6601, 7471, 7777, 8149,
                8401, 8911, 10001, 11111, 12403, 13981, 14701, 14911, 15211, 15841, 19201, 21931, 22321, 24013, 24661,
                27613, 29341, 34133, 34441, 35113, 38503, 41041, 45527, 46657, 48433, 50851, 50881, 52633, 54913, 57181,
                63139, 63973, 65311, 66991, 67861, 68101, 75361, 79003, 82513, 83119, 94139, 95161, 97273, 97681, 100001,
                101101, 101491, 102173, 108691, 113201, 115627, 115921, 118301, 118957, 122221, 126217, 128713, 130351,
                131821, 134821, 134863, 137137, 137149, 138481, 139231, 145181, 147001, 148417
            };

            List<int> actualOutput = ProjectEuler.Challenge130CompositesWithPrimeRepunitProperty.compositeInterval(LeftValue, RightValue);

            Assert.AreEqual(expectedOutput.Count, actualOutput.Count, "An unexpected number of items was returned!");

            for (int testValue = 0; testValue < expectedOutput.Count; testValue++)
            {
                Assert.AreEqual(expectedOutput[testValue], actualOutput[testValue], string.Format("test value {0} is incorrect", testValue));
            }
        }

        #endregion
    }
}
