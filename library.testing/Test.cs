using System;
using Xunit;
using library;

namespace library.testing
{
    public class Test
    {
        [Fact]
        public void TestingAdd()
        {
            var calc = new Calc();
            var actual = calc.Add(1, 2);
            Assert.Equal(3, actual);
        }

        [Fact]
        public void TestingSub()
        {
            var calc = new Calc();
            var actual = calc.Sub(1, 2);
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void TestingMultiply()
        {
            var calc = new Calc();
            var actual = calc.Multiply(2, 4);
            Assert.Equal(8, actual);
        }
    }
}
