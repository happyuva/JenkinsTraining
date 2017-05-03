using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App28ut
{
    [TestClass]
    public class CounterTest
    {
        [TestMethod]
        public void CounterTest01()
        {
            Counter c = new Counter(1000);

            int value = c.Increment();
            Assert.AreEqual(1001, value);

            value = c.Increment();
            Assert.AreEqual(1002, value);

            value = c.Decrement();
            Assert.AreEqual(1001, value);
        }

        [TestMethod]
        public void CounterTest02()
        {
            Counter c = new Counter();
            c.Count = 9000;

            c.Increment();
            Assert.AreEqual(9001, c.Count);
        }
    }
}
