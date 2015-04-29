using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vanguard.Test
{
    /// <summary>
    /// The Guard test class.
    /// </summary>
    [TestClass]
    public class GuardIsTest
    {
        [TestMethod]
        public void Guard_IsNotNull_Object_NotNull()
        {
            // Arrange
            object value = "value";

            // Act
            Action action = () => Guard.IsNotNull(value);

            // Assert
            action.ShouldNotThrow<ArgumentNullException>(because: "we supplied a non null parameter value");
        }

        [TestMethod]
        public void Guard_IsNotNull_Object_Null()
        {
            // Arrange
            object value = null;
            string exceptionMessage = "Exception of type 'Vanguard.GuardNullException' was thrown.";

            // Act
            Action action = () => Guard.IsNotNull(value);

            // Assert
            action.ShouldThrow<GuardNullException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_IsNotNull_Object_Message()
        {
            // Arrange
            object value = null;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.IsNotNull(value, message);

            // Assert
            action.ShouldThrow<GuardNullException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_IsNotNullOrEmpty_String_Null()
        {
            // Arrange
            string value = null;
            string exceptionMessage = "Exception of type 'Vanguard.GuardNullException' was thrown.";

            // Act
            Action action = () => Guard.IsNotNullOrEmpty(value);

            // Assert
            action.ShouldThrow<GuardNullException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_IsNotNullOrEmpty_String_Empty()
        {
            // Arrange
            string value = string.Empty;
            string exceptionMessage = "Exception of type 'Vanguard.GuardEmptyException' was thrown.";

            // Act
            Action action = () => Guard.IsNotNullOrEmpty(value);

            // Assert
            action.ShouldThrow<GuardException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_IsNotNullOrEmpty_String_Message()
        {
            // Arrange
            string value = string.Empty;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.IsNotNullOrEmpty(value, message);

            // Assert
            action.ShouldThrow<GuardException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_IsNotNullOrEmpty_Guid_Null()
        {
            // Arrange
            Guid? value = null;
            string exceptionMessage = "Exception of type 'Vanguard.GuardNullException' was thrown.";

            // Act
            Action action = () => Guard.IsNotNullOrEmpty(value);

            // Assert
            action.ShouldThrow<GuardNullException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_IsNotNullOrEmpty_Guid_Empty()
        {
            // Arrange
            Guid value = Guid.Empty;
            string exceptionMessage = "Exception of type 'Vanguard.GuardEmptyException' was thrown.";

            // Act
            Action action = () => Guard.IsNotNullOrEmpty(value);

            // Assert
            action.ShouldThrow<GuardException>(because: "we supplied a null parameter value")
                  .WithMessage(exceptionMessage, because: "that is the default exception message");
        }

        [TestMethod]
        public void Guard_IsNotNullOrEmpty_Guid_Message()
        {
            // Arrange
            Guid value = Guid.Empty;
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.IsNotNullOrEmpty(value, message);

            // Assert
            action.ShouldThrow<GuardException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_IsInRange_Byte_InRange()
        {
            // Arrange
            byte value = 1;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.IsInRange(value, range);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_IsInRange_Byte_OutOfRange()
        {
            // Arrange
            byte value = 20;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.IsInRange(value, range);

            // Assert
            action.ShouldThrow<GuardOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_IsInRange_Byte_Message()
        {
            // Arrange
            byte value = 20;
            ArgumentRange range = new ArgumentRange(0, 10);
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.IsInRange(value, range, message);

            // Assert
            action.ShouldThrow<GuardOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_IsInRange_Int_InRange()
        {
            // Arrange
            int value = 1;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.IsInRange(value, range);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_IsInRange_Int_OutOfRange()
        {
            // Arrange
            int value = 20;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.IsInRange(value, range);

            // Assert
            action.ShouldThrow<GuardOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_IsInRange_Int_Message()
        {
            // Arrange
            int value = 20;
            ArgumentRange range = new ArgumentRange(0, 10);
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.IsInRange(value, range, message);

            // Assert
            action.ShouldThrow<GuardOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_IsInRange_Short_InRange()
        {
            // Arrange
            short value = 1;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.IsInRange(value, range);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_IsInRange_Short_OutOfRange()
        {
            // Arrange
            short value = 20;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.IsInRange(value, range);

            // Assert
            action.ShouldThrow<GuardOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_IsInRange_Short_Message()
        {
            // Arrange
            short value = 20;
            ArgumentRange range = new ArgumentRange(0, 10);
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.IsInRange(value, range, message);

            // Assert
            action.ShouldThrow<GuardOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_IsInRange_Long_InRange()
        {
            // Arrange
            long value = 1;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.IsInRange(value, range);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_IsInRange_Long_OutOfRange()
        {
            // Arrange
            long value = 20;
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.IsInRange(value, range);

            // Assert
            action.ShouldThrow<GuardOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_IsInRange_Long_Message()
        {
            // Arrange
            long value = 20;
            ArgumentRange range = new ArgumentRange(0, 10);
            string message = "message";
            string exceptionMessage = "message";

            // Act
            Action action = () => Guard.IsInRange(value, range, message);

            // Assert
            action.ShouldThrow<GuardOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }
    }
}
