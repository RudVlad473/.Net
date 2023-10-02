using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Extensions
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void CustomReverse_ReversesString()
        {
            // Arrange
            string input = "Hello, World!";
            string expected = "!dlroW ,olleH"; // Reversed string

            // Act
            string result = input.CustomReverse();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CharCount_CountsCharacterOccurrences()
        {
            // Arrange
            string input = "Hello, World!";
            char targetChar = 'o';
            int expectedCount = 2; // 'o' occurs twice in the input string

            // Act
            int result = input.CharCount(targetChar);

            // Assert
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CharCount_CountsCharacterOccurrences_CaseSensitive()
        {
            // Arrange
            string input = "Hello, World!";
            char targetChar = 'O'; // Capital 'O' is different from 'o'
            int expectedCount = 0; // 'O' does not occur in the input string

            // Act
            int result = input.CharCount(targetChar);

            // Assert
            Assert.AreEqual(expectedCount, result);
        }
    }
}
