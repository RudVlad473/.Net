using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Extensions
{
    [TestClass]
    public class ArrayExtensionTests
    {
        [TestMethod]
        public void CountValue_CountsOccurrencesOfValue()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 4, 2, 5 };
            int value = 2;
            int expectedCount = 3; // '2' occurs 3 times in the array

            // Act
            int result = array.CountValue(value);

            // Assert
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void CountValue_CountsOccurrencesOfValueWithNulls()
        {
            // Arrange
            int?[] array = { 1, null, 3, null, 4, null, 5 };
            int? value = null;
            int expectedCount = 3; // 'null' occurs 3 times in the array

            // Act
            int result = array.CountValue(value);

            // Assert
            Assert.AreEqual(expectedCount, result);
        }

        [TestMethod]
        public void GetCopyWithUniqueValues_ReturnsArrayWithUniqueValues()
        {
            // Arrange
            int[] array = { 1, 2, 3, 2, 4, 2, 5 };
            int[] expectedArray = { 1, 2, 3, 4, 5 }; // Unique values in the array

            // Act
            int[] result = array.GetCopyWithUniqueValues();

            // Assert
            CollectionAssert.AreEqual(expectedArray, result);
        }
    }
}
