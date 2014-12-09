﻿// We are given a string containing a list of forbidden words and a text containing some of these words. 
// Write a program that replaces the forbidden words with asterisks. Example:
// Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and
// is implemented as a dynamic language in CLR.
// Words: "PHP, CLR, Microsoft"
// The expected result:
// ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and 
// is implemented as a dynamic language in ***.

using System;
using System.Text;

class WordsReplace
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today." +
            " It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP, CLR, Microsoft";
        string[] separators = { " ", "," };
        string[] wordsInArray = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder copy = new StringBuilder();
        copy.Append(text);

        for (int i = 0; i < wordsInArray.Length; i++)
        {
            copy.Replace(wordsInArray[i], new string('*', wordsInArray[i].Length));
        }

        Console.WriteLine("The input text is:");
        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine("The forbidden words are:");
        Console.WriteLine(words);
        Console.WriteLine();
        Console.WriteLine("The output text is:");
        Console.WriteLine(copy.ToString());
    }
}
