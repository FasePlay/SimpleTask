using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        string message = Console.ReadLine();

        string[] words1 = message.Split(' ');
        List<string> words2 = new List<string>();

        for (int i = 0; i < words1.Length; i++)
        {
            if (Reverse(words1[i]).Equals(words1[i]))
                words2.Add(words1[i]);
        }

        foreach (string word in words2)
        {
            Console.Write(word + "; ");
        }
        
    }

    public static string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
