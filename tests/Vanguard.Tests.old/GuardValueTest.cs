using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vanguard.Test
{
    /// <summary>
    /// The Guard test class.
    /// </summary>
    [TestClass]
    public class GuardValueTest
    {
        [TestMethod]
        public void Guard_ValueNotNull_Object_NotNull()
        {
            // Arrange
            object value = "value";

            // Act
            Action action = () => Guard.ValueNotNull(value);

            // Assert
            action.ShouldNotThrow<ArgumentNullException>(because: "we supplied a non null parameter value");
        }

        [TestMethod]
        public void Guard_ValueNotNull_Object_Null()
        {
            // Arrange
            object value = null;
            string exceptionMessage = "Value cannot be null.";

            // Act
            Action action = () => Guard.ValueNotNull(value);

            // Assert
            action.ShouldThrow<ValueNullException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_ValueNotNull_Object_Message()
        {
            // Arrange
            object value = null;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.ValueNotNull(value, message);

            // Assert
            action.ShouldThrow<ValueNullException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ValueNotNullOrEmpty_String_Null()
        {
            // Arrange
            string value = null;
            string exceptionMessage = "Value cannot be null.";

            // Act
            Action action = () => Guard.ValueNotNullOrEmpty(value);

            // Assert
            action.ShouldThrow<ValueNullException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_ValueNotNullOrEmpty_String_Empty()
        {
            // Arrange
            string value = string.Empty;
            string exceptionMessage = "Value cannot be empty.";

            // Act
            Action action = () => Guard.ValueNotNullOrEmpty(value);

            // Assert
            action.ShouldThrow<GuardException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_ValueNotNullOrEmpty_String_Message()
        {
            // Arrange
            string value = string.Empty;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.ValueNotNullOrEmpty(value, message);

            // Assert
            action.ShouldThrow<GuardException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ValueNotNullOrEmpty_Guid_Null()
        {
            // Arrange
            Guid? value = null;
            string exceptionMessage = "Value cannot be null.";

            // Act
            Action action = () => Guard.ValueNotNullOrEmpty(value);

            // Assert
            action.ShouldThrow<ValueNullException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_ValueNotNullOrEmpty_Guid_Empty()
        {
            // Arrange
            Guid value = Guid.Empty;
            string exceptionMessage = "Value cannot be empty.";

            // Act
            Action action = () => Guard.ValueNotNullOrEmpty(value);

            // Assert
            action.ShouldThrow<GuardException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_ValueNotNullOrEmpty_Guid_Message()
        {
            // Arrange
            Guid value = Guid.Empty;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.ValueNotNullOrEmpty(value, message);

            // Assert
            action.ShouldThrow<GuardException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ValueInRange_Byte_InRange()
        {
            // Arrange
            byte value = 1;
            byte minimum = 0; 
            byte maximum = 10;

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ValueInRange_Byte_OutOfRange()
        {
            // Arrange
            byte value = 20;
            byte minimum = 0; 
            byte maximum = 10;

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum);

            // Assert
            action.ShouldThrow<ValueOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ValueInRange_Byte_Message()
        {
            // Arrange
            byte value = 20;
            byte minimum = 0; 
            byte maximum = 10;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum, message);

            // Assert
            action.ShouldThrow<ValueOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ValueInRange_Int_InRange()
        {
            // Arrange
            int value = 1;
            int minimum = 0; 
            int maximum = 10;

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ValueInRange_Int_OutOfRange()
        {
            // Arrange
            int value = 20;
            int minimum = 0; 
            int maximum = 10;

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum);

            // Assert
            action.ShouldThrow<ValueOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ValueInRange_Int_Message()
        {
            // Arrange
            int value = 20;
            int minimum = 0;
            int maximum = 10;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum, message);

            // Assert
            action.ShouldThrow<ValueOutOfRangeException>()
                .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ValueInRange_Short_InRange()
        {
            // Arrange
            short value = 1;
            short minimum = 0;
            short maximum = 10;

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ValueInRange_Short_OutOfRange()
        {
            // Arrange
            short value = 20;
            short minimum = 0;
            short maximum = 10;

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum);

            // Assert
            action.ShouldThrow<ValueOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ValueInRange_Short_Message()
        {
            // Arrange
            short value = 20;
            short minimum = 0;
            short maximum = 10;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum, message);

            // Assert
            action.ShouldThrow<ValueOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ValueInRange_Long_InRange()
        {
            // Arrange
            long value = 1;
            long minimum = 0;
            long maximum = 10;

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ValueInRange_Long_OutOfRange()
        {
            // Arrange
            long value = 20;
            long minimum = 0;
            long maximum = 10;

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum);

            // Assert
            action.ShouldThrow<ValueOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ValueInRange_Long_Message()
        {
            // Arrange
            long value = 20;
            long minimum = 0;
            long maximum = 10;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.ValueInRange(value, minimum, maximum, message);

            // Assert
            action.ShouldThrow<ValueOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }
    }
}
