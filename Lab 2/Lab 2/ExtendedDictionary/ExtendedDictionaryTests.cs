using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.ExtendedDictionary
{
    [TestClass]
    public class ExtendedDictionaryTests
    {
        [TestMethod]
        public void Add_AddsKeyValuePair()
        {
            // Arrange
            ExtendedDictionary<string, int, double> dictionary =
                new ExtendedDictionary<string, int, double>();
            string key = "Key";
            int value1 = 42;
            double value2 = 3.14;

            // Act
            dictionary.Add(key, value1, value2);

            // Assert
            Assert.AreEqual(1, dictionary.Count);
            Assert.IsTrue(dictionary.ContainsKey(key));
            Assert.AreEqual(value1, dictionary[key].Item1);
            Assert.AreEqual(value2, dictionary[key].Item2);
        }

        [TestMethod]
        public void Remove_RemovesKeyValuePair()
        {
            // Arrange
            ExtendedDictionary<string, int, double> dictionary =
                new ExtendedDictionary<string, int, double>();
            string key = "Key";
            int value1 = 42;
            double value2 = 3.14;
            dictionary.Add(key, value1, value2);

            // Act
            dictionary.Remove(key);

            // Assert
            Assert.AreEqual(0, dictionary.Count);
            Assert.IsFalse(dictionary.ContainsKey(key));
        }

        [TestMethod]
        public void ContainsKey_ChecksIfKeyExists()
        {
            // Arrange
            ExtendedDictionary<string, int, double> dictionary =
                new ExtendedDictionary<string, int, double>();
            string key = "Key";
            dictionary.Add(key, 42, 3.14);

            // Act & Assert
            Assert.IsTrue(dictionary.ContainsKey(key));
            Assert.IsFalse(dictionary.ContainsKey("NonExistentKey"));
        }

        [TestMethod]
        public void ContainsValues_ChecksIfValuesExist()
        {
            // Arrange
            ExtendedDictionary<string, int, double> dictionary =
                new ExtendedDictionary<string, int, double>();
            dictionary.Add("Key1", 42, 3.14);
            dictionary.Add("Key2", 42, 2.71);

            // Act & Assert
            Assert.IsTrue(dictionary.ContainsValues(42, 3.14));
            Assert.IsFalse(dictionary.ContainsValues(42, 1.23));
        }
    }
}
