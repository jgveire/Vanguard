using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vanguard.Test
{
    /// <summary>
    /// The Guard test class.
    /// </summary>
    [TestClass]
    public class GuardArgumentTest
    {
        [TestMethod]
        public void Guard_ArgumentNotNull_Object_NotNull()
        {
            // Arrange
            object value = "value";
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentNotNull<object>(value, name);
            // Assert
            action.Should().NotThrow<ArgumentNullException>(because: "we supplied a non null parameter value");
        }

        [TestMethod]
        public void Guard_ArgumentNotNull_Object_Null()
        {
            // Arrange
            object value = null;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentNotNull<object>(value, name);

            // Assert
            action.Should().Throw<ArgumentNullException>(because: "we supplied a null parameter value");
        }

        [TestMethod]
        public void Guard_ArgumentNotNull_Object_Message()
        {
            // Arrange
            object value = null;
            string name = "name";
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentNotNull<object>(value, name, message);

            // Assert
            action.Should().Throw<ArgumentNullException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentNotNullOrEmpty_String_Null()
        {
            // Arrange
            string value = null;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentNotNullOrEmpty<string>(value, name);

            // Assert
            action.Should().Throw<ArgumentException>(because: "we supplied a null parameter value");
        }

        [TestMethod]
        public void Guard_ArgumentNotNullOrEmpty_String_Empty()
        {
            // Arrange
            string value = string.Empty;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentNotNullOrEmpty<string>(value, name);

            // Assert
            action.Should().Throw<ArgumentException>(because: "we supplied a null parameter value");
        }

        [TestMethod]
        public void Guard_ArgumentNotNullOrEmpty_String_Message()
        {
            // Arrange
            string value = string.Empty;
            string name = "name";
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentNotNullOrEmpty<string>(value, name, message);

            // Assert
            action.Should().Throw<ArgumentException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentNotNullOrEmpty_Guid_Null()
        {
            // Arrange
            Guid? value = null;
            string name = "name";
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentNotNullOrEmpty<Guid?>(value, name, message);

            // Assert
            action.Should().Throw<ArgumentNullException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage);
        }

        [TestMethod]
        public void Guard_ArgumentNotNullOrEmpty_Guid_Empty()
        {
            // Arrange
            Guid value = Guid.Empty;
            string name = "name";
            string message = "message";

            // Act
            Action action = () => Guard.ArgumentNotNullOrEmpty<Guid>(value, name, message);

            // Assert
            action.Should().Throw<ArgumentException>(because: "we supplied a null parameter value");
        }

        [TestMethod]
        public void Guard_ArgumentNotNullOrEmpty_Guid_Message()
        {
            // Arrange
            Guid value = Guid.Empty;
            string name = "name";
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentNotNullOrEmpty<Guid>(value, name, message);

            // Assert
            action.Should().Throw<ArgumentException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }
        
        [TestMethod]
        public void Guard_ArgumentInRange_Byte_InRange()
        {
            // Arrange
            byte value = 1;
            byte minimum = 0;
            byte maximum = 10;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name);

            // Assert
            action.Should().NotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Byte_OutOfRange()
        {
            // Arrange
            byte value = 20;
            byte minimum = 0;
            byte maximum = 10;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Byte_Message()
        {
            // Arrange
            byte value = 20;
            byte minimum = 0;
            byte maximum = 10;
            string name = "name";
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name, message);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Int_InRange()
        {
            // Arrange
            int value = 1;
            int minimum = 0;
            int maximum = 10;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name);

            // Assert
            action.Should().NotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Int_OutOfRange()
        {
            // Arrange
            int value = 20;
            int minimum = 0;
            int maximum = 10;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Int_Message()
        {
            // Arrange
            int value = 20;
            int minimum = 0;
            int maximum = 10;
            string name = "name";
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name, message);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>()
                .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Int_Null()
        {
            // Arrange
            int? value = null;

            // Act
            Action action = () => Guard.ArgumentNotNull(value, "value");

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Short_InRange()
        {
            // Arrange
            short value = 1;
            short minimum = 0;
            short maximum = 10;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name);

            // Assert
            action.Should().NotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Short_OutOfRange()
        {
            // Arrange
            short value = 20;
            short minimum = 0;
            short maximum = 10;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Short_Message()
        {
            // Arrange
            short value = 20;
            short minimum = 0;
            short maximum = 10;
            string name = "name";
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name, message);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Long_InRange()
        {
            // Arrange
            long value = 1;
            long minimum = 0;
            long maximum = 10;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name);

            // Assert
            action.Should().NotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Long_OutOfRange()
        {
            // Arrange
            long value = 20;
            long minimum = 0;
            long maximum = 10;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Long_Message()
        {
            // Arrange
            long value = 20;
            long minimum = 0;
            long maximum = 10;
            string name = "name";
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, minimum, maximum, name, message);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }
    }
}
