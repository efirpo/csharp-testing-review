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
      Sentence = input.ToLower();
    }
    public static bool CheckWord()
    {
      bool check = true;
      string[] numCheck = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
      string[] charCheck = { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "{", "}", "[", "]", "\\", "|", ":", ";", "\"", "\'", "<", ",", ">", ".", "?", "/" };
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
    public static int CheckSentence()
    {
      int wordCount = 0;
      char[] charCheck = { '.', ',', '?', '!', '\"', '\'', ':', ';', ' ' };
      string[] sentenceArray = Sentence.Split(charCheck);
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