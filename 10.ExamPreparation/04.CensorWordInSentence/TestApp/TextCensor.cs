using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp;

public class TextCensor
{
    public static string CensorWord(string sentence, string wordToCensor)
    {
        if (string.IsNullOrWhiteSpace(sentence))
        {
            return "Sentence cannot be empty.";
        }

        if (string.IsNullOrWhiteSpace(wordToCensor))
        {
            return "Word to censor cannot be empty.";
        }

        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].ToLower() == wordToCensor.ToLower())
            {
                words[i] = new string('*', wordToCensor.Length);
            }
        }

        return string.Join(" ", words);
    }
}
