using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordCounterApp
  {
    public static string Word { get; set; }
    public static string Sentence { get; set; }

    public static void GetWord(string input)
    {
      Word = input.ToLower();
    }
    public static void GetSentence(string input)
    {
      Sentence = input;
    }
    public static bool CheckWord()
    {
      bool check = true;
      string[] numCheck = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
      string[] charCheck = { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "{", "}", "[", "]", "\\", "|", ":", ";", "\"", "\'", "<", ",", ">", ".", "?", "/", " " };
      for (int i = 0; i < numCheck.Length; i++)
      {
        if (Word.Contains(numCheck[i]))
        {
          check = false;
        }
      }
      for (int i = 0; i < charCheck.Length; i++)
      {
        if (Word.Contains(charCheck[i]))
        {
          check = false;
        }
      }
      return check;
    }
    public static bool CheckSentence()
    {
      bool check = true;
      string[] numCheck = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
      string[] charCheck = { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "{", "}", "[", "]", "\\", "|", ":", ";", "\"", "\'", "<", ",", ">", ".", "?", "/", " " };
      char[] charSplit = { '.', ',', '?', '!', '\"', '\'', ':', ';', '/', '(', ')', '-', ' ' };
      string[] sentenceArray = Sentence.Split(charSplit);
      foreach (string word in sentenceArray)
      {
        for (int i = 0; i < charCheck.Length; i++)
        {
          if (word.Contains(charCheck[i]))
          {
            check = false;
          }
        }
        for (int i = 0; i < numCheck.Length; i++)
        {
          if (word.Contains(numCheck[i]))
          {
            check = false;
          }
        }
      }
      if (sentenceArray.Length == 1)
      {
        check = false;
      }
      else if (Sentence[0].ToString() == (Char.ToLower(Sentence[0]).ToString()))
      {
        check = false;
      }
      else if (Sentence[Sentence.Length - 1] == '.' || Sentence[Sentence.Length - 1] == '!' || Sentence[Sentence.Length - 1] == '?')
      {
        check = true;
      }
      else
      {
        check = false;
      }

      return check;
    }
    public static int CountSentence()
    {
      Sentence.ToLower();
      int wordCount = 0;
      char[] charSplit = { '.', ',', '?', '!', '\"', '\'', ':', ';', '/', '(', ')', '-', ' ' };
      string[] sentenceArray = Sentence.Split(charSplit);
      for (int i = 0; i < sentenceArray.Length; i++)
      {
        if (Word == sentenceArray[i])
        {
          wordCount++;
        }
      }
      return wordCount;
    }
  }
}