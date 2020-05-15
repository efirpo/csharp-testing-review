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
      // Arrange
      WordCounterApp word = new WordCounterApp();
      // Act
      WordCounterApp.GetWord("chuck");
      // Assert
      Assert.AreEqual(typeof(string), WordCounterApp.Word.GetType());
    }

    [TestMethod]
    public void Sentence_CheckIfSentenceIsValidString_String()
    {
      // Arrange
      WordCounterApp word = new WordCounterApp();
      // Act
      WordCounterApp.GetSentence("How much wood would a woodchuck chuck if a woodchuck could chuck wood?");
      // Assert
      Assert.AreEqual(typeof(string), WordCounterApp.Sentence.GetType());
    }

    [TestMethod]
    public void Word_CheckIfWordContainsNoNumbers_False()
    {
      // Arrange
      WordCounterApp word = new WordCounterApp();
      // Act
      WordCounterApp.GetWord("ch9ck");
      // Assert
      Assert.AreEqual(false, WordCounterApp.CheckWord());
    }

    [TestMethod]
    public void Word_CheckIfWordContainsNoNonAlphabeticalCharacters_False()
    {
      // Arrange
      WordCounterApp word = new WordCounterApp();
      // Act
      WordCounterApp.GetWord("chu!k");
      // Assert
      Assert.AreEqual(false, WordCounterApp.CheckWord());
    }

    [TestMethod]
    public void Sentence_CheckHowManyTimesWordAppearsInSentence_Two()
    {
      // Act
      WordCounterApp word = new WordCounterApp();
      // Arrange
      WordCounterApp.GetWord("chuck");
      WordCounterApp.GetSentence("How much wood would a woodchuck chuck, if a woodchuck could chuck wood?");
      // Assert
      Assert.AreEqual(2, WordCounterApp.CheckSentence());

    }

  }
}