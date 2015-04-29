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
            Action action = () => Guard.ArgumentNotNull(value, name);

            // Assert
            action.ShouldNotThrow<ArgumentNullException>(because: "we supplied a non null parameter value");
        }

        [TestMethod]
        public void Guard_ArgumentNotNull_Object_Null()
        {
            // Arrange
            object value = null;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentNotNull(value, name);

            // Assert
            action.ShouldThrow<ArgumentNullException>(because: "we supplied a null parameter value");
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
            Action action = () => Guard.ArgumentNotNull(value, name, message);

            // Assert
            action.ShouldThrow<ArgumentNullException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentNotNullOrEmpty_String_Null()
        {
            // Arrange
            string value = null;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentNotNullOrEmpty(value, name);

            // Assert
            action.ShouldThrow<ArgumentException>(because: "we supplied a null parameter value");
        }

        [TestMethod]
        public void Guard_ArgumentNotNullOrEmpty_String_Empty()
        {
            // Arrange
            string value = string.Empty;
            string name = "name";

            // Act
            Action action = () => Guard.ArgumentNotNullOrEmpty(value, name);

            // Assert
            action.ShouldThrow<ArgumentException>(because: "we supplied a null parameter value");
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
            Action action = () => Guard.ArgumentNotNullOrEmpty(value, name, message);

            // Assert
            action.ShouldThrow<ArgumentException>()
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
            Action action = () => Guard.ArgumentNotNullOrEmpty(value, name, message);

            // Assert
            action.ShouldThrow<ArgumentNullException>(because: "we supplied a null parameter value")
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
            Action action = () => Guard.ArgumentNotNullOrEmpty(value, name, message);

            // Assert
            action.ShouldThrow<ArgumentException>(because: "we supplied a null parameter value");
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
            Action action = () => Guard.ArgumentNotNullOrEmpty(value, name, message);

            // Assert
            action.ShouldThrow<ArgumentException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Byte_InRange()
        {
            // Arrange
            byte value = 1;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Byte_OutOfRange()
        {
            // Arrange
            byte value = 20;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Byte_Message()
        {
            // Arrange
            byte value = 20;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range, message);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Int_InRange()
        {
            // Arrange
            int value = 1;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Int_OutOfRange()
        {
            // Arrange
            int value = 20;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Int_Message()
        {
            // Arrange
            int value = 20;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range, message);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Short_InRange()
        {
            // Arrange
            short value = 1;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Short_OutOfRange()
        {
            // Arrange
            short value = 20;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Short_Message()
        {
            // Arrange
            short value = 20;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range, message);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Long_InRange()
        {
            // Arrange
            long value = 1;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range);

            // Assert
            action.ShouldNotThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value in the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Long_OutOfRange()
        {
            // Arrange
            long value = 20;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>(because: "we supplied a parameter value outside the range");
        }

        [TestMethod]
        public void Guard_ArgumentInRange_Long_Message()
        {
            // Arrange
            long value = 20;
            string name = "name";
            ArgumentRange range = new ArgumentRange(0, 10);
            string message = "message";
            string exceptionMessage = "message\r\nParameter name: name";

            // Act
            Action action = () => Guard.ArgumentInRange(value, name, range, message);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>()
                  .WithMessage(exceptionMessage, because: "we supplied the message as argument");
        }
    }
}
