using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLab_4;

namespace TestLab_4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void random_String()
        {
            // arrange
            int length = 7;

            int expected = 7;


            // act
            String have_str = RandomString(length);
            int actual = have_str.Length;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
