using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TranslateSentence("He said, \"When will this all end?\"");
        }

        public static string TranslateWord(string word)
        {
            if(word.Length == 0 || word == null)
                return word;

            bool toUpper = false;

            if (char.IsUpper(word[0]))
            {
                toUpper = true;
            }

            word = word.ToLower();

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', };
            string newWord = "";

            if (vowels.Contains(word[0]))
            {
                newWord += word + "yay";
            }
            else
            {
                int n = 0;
                string nn = "";

                while (!vowels.Contains(word[n]))
                {
                    nn += word[n];
                    n++;
                }

                for (int i = n; i < word.Length; i++)
                {
                    newWord += "" + word[i];
                }

                newWord += nn + "ay";
            }

            if (toUpper)
                newWord = char.ToUpper(newWord[0]) + newWord.Substring(1);

            return newWord;
        }

        public static string TranslateSentence(string sentence)
        {
            if (sentence.Length == 0 || sentence == null)
                return sentence;

            char[] fuck = new char[] { '!', '?', '.', ',', ' ', ':', '"'};

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', };
            string[] arr = sentence.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                string w = "";
                string y = "";
                if (fuck.Contains(arr[i][arr[i].Length - 1]))
                {
                    
                    while (fuck.Contains(arr[i][arr[i].Length - 1]))
                    {
                        w += "" + arr[i][arr[i].Length - 1];
                        arr[i] = arr[i].Substring(0, arr[i].Length-1);
                        
                    }

                    char[] ww = w.ToCharArray();
                    Array.Reverse(ww);
                    w = new string(ww);
                }

                int q = 0;
                if(fuck.Contains(arr[i][q]))
                {
                    y = "" + arr[i][q];
                    q++;
                }

                bool toUpper = false;

                if (char.IsUpper(arr[i][q]))
                {
                    toUpper = true;
                }

                arr[i] = arr[i].ToLower();
                string newWord = "";

                if (vowels.Contains(arr[i][0]))
                {
                    newWord += arr[i] + "yay";
                }
                else
                {
                    int n = q;
                    string nn = "";

                    while (!vowels.Contains(arr[i][n]))
                    {
                        nn += arr[i][n];
                        n++;
                    }

                    for (int k = n; k < arr[i].Length; k++)
                    {
                        newWord += "" + arr[i][k];
                    }

                    newWord += nn + "ay";
                }

                if (toUpper)
                {
                    newWord = char.ToUpper(newWord[q--]) + newWord.Substring(1);
                }

                arr[i] = y + newWord + w;
            }

            string txt = string.Join(" ", arr);

            return txt;
        }
    }
}
