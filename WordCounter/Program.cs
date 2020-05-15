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
      Console.WriteLine("\nHere at Word Counter App we believe in high-level design and agile functionality adapted to our fast-paced modern world.\n\nWould you like to check a sentence to see how many times a certain word appears in it? [ Y / N ]\n");
      string tryInput = Console.ReadLine().ToLower();
      if (tryInput == "y")
      {
        Console.WriteLine("\nWe knew you were the clever sort.");
      GetWordInput:
        Console.WriteLine("\nPlease enter a word below:\n");
        WordCounterApp.GetWord(Console.ReadLine());
        bool checkWord = WordCounterApp.CheckWord();
        if (checkWord == false)
        {
          Console.WriteLine("\nYou must have typoed. Please enter a single word that contains only alphabetical characters.");
          goto GetWordInput;
        }
        else
        {
        GetSentenceInput:
          Console.WriteLine("\nPlease enter a sentence to check the word against:\n");
          WordCounterApp.GetSentence(Console.ReadLine());
          Console.WriteLine(WordCounterApp.Sentence[0]);
          Console.WriteLine(Char.ToLower(WordCounterApp.Sentence[0]));
          bool checkSentence = WordCounterApp.CheckSentence();
          if (checkSentence == false)
          {
            Console.WriteLine("\nIt seems like you didn't enter a proper sentence. Please check your punctuation, capitalization, and spelling, and make sure you're entering an actual sentence.\n");
            goto GetSentenceInput;
          }
          else
          {
            int wordCount = WordCounterApp.CountSentence();
            Console.WriteLine("\nYour sentence contains the word \"" + WordCounterApp.Word + "\" " + wordCount + " times. Wow!\n");
            Console.WriteLine("Would you like to try again? [ Y / N ]\n");
            string tryAgain = Console.ReadLine().ToLower();
            if (tryAgain == "y")
            {
              goto GetWordInput;
            }
            else if (tryAgain == "n")
            {
              Console.WriteLine("\nThank you for trying out our next-level program.\n");
              Console.WriteLine("                        _ _                _ ");
              Console.WriteLine("                       | | |              | |");
              Console.WriteLine("   __ _  ___   ___   __| | |__  _   _  ___| |");
              Console.WriteLine("  / _` |/ _ \\ / _ \\ / _` | '_ \\| | | |/ _ \\ |");
              Console.WriteLine(" | (_| | (_) | (_) | (_| | |_) | |_| |  __/_|");
              Console.WriteLine("  \\__, |\\___/ \\___/ \\__,_|_.__/ \\__, |\\___(_)");
              Console.WriteLine("   __/ |                         __/ |");
              Console.WriteLine("  |___/                         |___/ \n");
            }
          }
        }
      }
      else if (tryInput == "n")
      {
        Console.WriteLine("\nWe understand. Not everyone can handle the insane actualization of compatibility-oriented utility here at Word Counter App.\n \nPlease come back another time if you find yourself ready to get your mind blown.\n");
        Console.WriteLine("                        _ _                _ ");
        Console.WriteLine("                       | | |              | |");
        Console.WriteLine("   __ _  ___   ___   __| | |__  _   _  ___| |");
        Console.WriteLine("  / _` |/ _ \\ / _ \\ / _` | '_ \\| | | |/ _ \\ |");
        Console.WriteLine(" | (_| | (_) | (_) | (_| | |_) | |_| |  __/_|");
        Console.WriteLine("  \\__, |\\___/ \\___/ \\__,_|_.__/ \\__, |\\___(_)");
        Console.WriteLine("   __/ |                         __/ |");
        Console.WriteLine("  |___/                         |___/ \n");
      }
    }
  }
}