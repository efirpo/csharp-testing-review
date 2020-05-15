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
    [TestMethod]
    public void Sentence_CheckIfSentenceIsValidString_String()
    {
      // Act
      WordCounterApp word = new WordCounterApp();
      // Arrange
      WordCounterApp.GetSentence("How much wood would a woodchuck chuck if a woodchuck could chuck wood?");
      // Assert
      Assert.AreEqual(typeof(string), WordCounterApp.Sentence.GetType());
    }
    [TestMethod]
    public void Word_CheckIfWordContainsNoNumbers_False()
    {
      // Act
      WordCounterApp word = new WordCounterApp();
      // Arrange
      WordCounterApp.GetWord("ch9ck");
      // Assert
      Assert.AreEqual(false, WordCounterApp.CheckWord());
    }
    public void Sentence_CheckHowManyTimesWordAppearsInSentence_Two()
    {
      // Act
      WordCounterApp word = new WordCounterApp();
      // Arrange
      WordCounterApp.GetWord("chuck");
      // Assert
      Assert.AreEqual(2, WordCounterApp.CheckSentence());

    }

  }
}