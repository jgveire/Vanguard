using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vanguard.Test
{
    [TestClass]
    public class ArgumentRangeTest
    {
        [TestMethod]
        public void ArgumentRange_Constructor_Byte()
        {
            // Arrange & Act
            ArgumentRange range = new ArgumentRange(byte.MinValue, byte.MaxValue);

            // Assert
            range.Minimum.Should().Be(byte.MinValue, because: "we supplied the constructor with byte min value");
            range.Maximum.Should().Be(byte.MaxValue, because: "we supplied the constructor with byte max value");
        }

        [TestMethod]
        public void ArgumentRange_Constructor_Int()
        {
            // Arrange & Act
            ArgumentRange range = new ArgumentRange(int.MinValue, int.MaxValue);

            // Assert
            range.Minimum.Should().Be(int.MinValue, because: "we supplied the constructor with int min value");
            range.Maximum.Should().Be(int.MaxValue, because: "we supplied the constructor with int max value");
        }

        [TestMethod]
        public void ArgumentRange_Constructor_Short()
        {
            // Arrange & Act
            ArgumentRange range = new ArgumentRange(short.MinValue, short.MaxValue);

            // Assert
            range.Minimum.Should().Be(short.MinValue, because: "we supplied the constructor with short min value");
            range.Maximum.Should().Be(short.MaxValue, because: "we supplied the constructor with short max value");
        }

        [TestMethod]
        public void ArgumentRange_Constructor_Long()
        {
            // Arrange & Act
            ArgumentRange range = new ArgumentRange(long.MinValue, long.MaxValue);

            // Assert
            range.Minimum.Should().Be(long.MinValue, because: "we supplied the constructor with long min value");
            range.Maximum.Should().Be(long.MaxValue, because: "we supplied the constructor with long max value");
        }

        [TestMethod]
        public void ArgumentRange_Equal_Operator_True()
        {
            // Arrange
            ArgumentRange range1 = new ArgumentRange(1, 2);
            ArgumentRange range2 = new ArgumentRange(1, 2);

            // Act
            bool result = range1 == range2;

            // Assert
            result.Should().BeTrue(because: "range 1 and 2 have both the same values");
        }

        [TestMethod]
        public void ArgumentRange_Equal_Operator_False()
        {
            // Arrange
            ArgumentRange range1 = new ArgumentRange(1, 2);
            ArgumentRange range2 = new ArgumentRange(2, 2);

            // Act
            bool result = range1 == range2;

            // Assert
            result.Should().BeFalse(because: "range 1 and 2 do not have both the same values");
        }

        [TestMethod]
        public void ArgumentRange_Not_Equal_Operator_True()
        {
            // Arrange
            ArgumentRange range1 = new ArgumentRange(1, 2);
            ArgumentRange range2 = new ArgumentRange(2, 2);

            // Act
            bool result = range1 != range2;

            // Assert
            result.Should().BeTrue(because: "range 1 and 2 do not have both the same values");
        }

        [TestMethod]
        public void ArgumentRange_Not_Equal_Operator_False()
        {
            // Arrange
            ArgumentRange range1 = new ArgumentRange(1, 2);
            ArgumentRange range2 = new ArgumentRange(1, 2);

            // Act
            bool result = range1 != range2;

            // Assert
            result.Should().BeFalse(because: "range 1 and 2 have both the same values");
        }

        [TestMethod]
        public void ArgumentRange_Equals()
        {
            // Arrange
            ArgumentRange range1 = new ArgumentRange(1, 2);
            ArgumentRange range2 = new ArgumentRange(1, 2);

            // Act
            bool result = range1.Equals(range2);

            // Assert
            result.Should().BeTrue(because: "range 1 and 2 have both the same values");
        }

        [TestMethod]
        public void ArgumentRange_GetHashCode()
        {
            // Arrange
            ArgumentRange range = new ArgumentRange(1, 2);
            int hashCode = 1 ^ 2;

            // Act
            int result = range.GetHashCode();

            // Assert
            result.Should().Be(hashCode, because: "we expect the minimum and maximum value to be seperated by a comma");
        }

        [TestMethod]
        public void ArgumentRange_ToString()
        {
            // Arrange
            ArgumentRange range = new ArgumentRange(1, 2);

            // Act
            string result = range.ToString();

            // Assert
            result.Should().Be("1 - 2", because: "we expect the minimum and maximum value to be seperated by a comma");
        }

        [TestMethod]
        public void ArgumentRange_ValueInRange_Short()
        {
            // Arrange
            short value = 5;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            bool result = range.ValueInRange(value);

            // Assert
            result.Should().BeTrue(because: "we supplied a parameter value in the range");
        }        

        [TestMethod]
        public void ArgumentRange_ValueInRange_Byte()
        {
            // Arrange
            byte value = 5;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            bool result = range.ValueInRange(value);

            // Assert
            result.Should().BeTrue(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void ArgumentRange_ValueInRange_Int()
        {
            // Arrange
            int value = 5;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            bool result = range.ValueInRange(value);

            // Assert
            result.Should().BeTrue(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void ArgumentRange_ValueInRange_Long()
        {
            // Arrange
            long value = 5;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            bool result = range.ValueInRange(value);

            // Assert
            result.Should().BeTrue(because: "we supplied a parameter value in the range");
        }
    }
}
