using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]

    public void Word_CheckIfWordInputIsValidString_String()
    {
      // Act
      WordCounterApp word = new WordCounterApp();
      // Arrange
      WordCounterApp.GetWord("chuck");
      // Assert
      Assert.AreEqual(typeof(string), WordCounterApp.Word.GetType());

    }

  }
}