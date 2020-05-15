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
      Console.WriteLine("\n                   Welcome to the");
      Console.WriteLine(" __          __           _    _____                  _");
      Console.WriteLine(" \\ \\        / /          | |  / ____|                | |                /\\");
      Console.WriteLine("  \\ \\  /\\  / /__  _ __ __| | | |     ___  _   _ _ __ | |_ ___ _ __     /  \\   _ __  _ __");
      Console.WriteLine("   \\ \\/  \\/ / _ \\| '__/ _` | | |    / _ \\| | | | '_ \\| __/ _ \\ '__|   / /\\ \\ | '_ \\| '_ \\ ");
      Console.WriteLine("    \\  /\\  / (_) | | | (_| | | |___| (_) | |_| | | | | ||  __/ |     / ____ \\| |_) | |_) |");
      Console.WriteLine("     \\/  \\/ \\___/|_|  \\__,_|  \\_____\\___/ \\__,_|_| |_|\\__\\___|_|    /_/    \\_\\ .__/| .__/ ");
      Console.WriteLine("                                                                             | |   | |");
      Console.WriteLine("                                                                             |_|   |_| ");
      Console.WriteLine("\nHere at Word Counter App we check a sentence to see how many times a certain word appears in it. Neat, huh? \nWould you like to try it out? [ Y/ N ]");
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