using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordApp
{
  public class Program
  {
    public static void Main()
    {
      WordCounterApp word = new WordCounterApp();
      Console.WriteLine("Welcome to the Word Counter App!\n Here at Word Counter App we check a sentence to see how many times a certain word appears in it. Neat, huh? \nWould you like to try it out? [ Y/ N ]");
      string tryInput = Console.ReadLine().ToLower();
      if (tryInput == "y")
      {
      GetWordInput:
        Console.WriteLine("Please enter a word below:");
        WordCounterApp.GetWord(Console.ReadLine());
        bool checkWord = WordCounterApp.CheckWord();
        if (checkWord == false)
        {
          Console.WriteLine("You must have typoed. Please enter a word that contains only alphabetical characters.");
          goto GetWordInput;
        }
        else
        {
          Console.WriteLine("Please enter a sentence to check the word against:");
          WordCounterApp.GetSentence(Console.ReadLine());
          int wordCount = WordCounterApp.CheckSentence();
          Console.WriteLine("Your sentence contains the word \"" + WordCounterApp.Word + "\" " + wordCount + " times.");
        }

      }
    }
  }
}