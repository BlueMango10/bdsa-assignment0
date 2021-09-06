using System;
using Xunit;

namespace Exercise.Test
{
    public class UnitTest
    {
        [Fact]
        public void DivisibleByFour()
        {
            Assert.True(Program.IsLeapYear(16));
        }
    }
}
