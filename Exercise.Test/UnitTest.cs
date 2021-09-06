using System;
using Xunit;

namespace Exercise.Test
{
    public class UnitTest
    {
        /*
        Rules:
        1: Divisible by 4 => leap year
        2: Divisible by 100 => not leap year (overrides rule 1)
        3: Divisible by 400 => leap year (overrides rule 2)
        */

        [Fact]
        public void RandomNonLeapYear()
        {
            Assert.False(Program.IsLeapYear(6));
        }

        [Fact]
        public void DivisibleByFour()
        {
            Assert.True(Program.IsLeapYear(16));
        }

        [Fact]
        public void DivisibleBy100()
        {
            Assert.False(Program.IsLeapYear(600));
        }

        [Fact]
        public void DivisibleBy400()
        {
            Assert.True(Program.IsLeapYear(1600));
        }
    }
}
