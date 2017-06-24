using System;
using System.Collections.Generic;
using Fibon.Service;
using Xunit;

namespace Fibon.Tests
{
    public class CalcTests
    {
        [Theory]
        [MemberData(nameof(Numbers))]
        public void FIbonacci_ReturnsCorrectValues(int number, int expectedResult)
        {
            ICalculator calc = new SlowOne();
            int result = calc.CalculateFibonacci(number);
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> Numbers()
        {
            yield return new object[] { 0, 0 };
            yield return new object[] { 1, 1 };
            yield return new object[] { 2, 1 };
            yield return new object[] { 3, 2 };
            yield return new object[] { 4, 3 };
            yield return new object[] { 5, 5 };
        }
    }
}
