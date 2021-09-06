using System;
using System.IO;
using Xunit;

namespace Exercise.Test
{
    public class IsLeapYearTest
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

    public class MainTest {
        [Fact]
        public void Yay()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Console.SetIn(new StringReader("2020"));
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim()[^3..];

            // Assert
            Assert.Equal("yay", output);
        }

        [Fact]
        public void Nay()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Console.SetIn(new StringReader("2021"));
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim()[^3..];

            // Assert
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Before1582()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Console.SetIn(new StringReader("24"));
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.EndsWith("Year must be after 1582!", output);
        }

        [Fact]
        public void ParseErrorNotNumber()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Console.SetIn(new StringReader("FooBar"));
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.EndsWith("Parse error", output);
        }

        [Fact]
        public void ParseErrorNotInt()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Console.SetIn(new StringReader("2012.4"));
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.EndsWith("Parse error", output);
        }

        [Fact]
        public void ParseErrorNumberTooLong()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Console.SetIn(new StringReader(int.MaxValue.ToString() + "0"));
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.EndsWith("Parse error", output);
        }
    }
}
