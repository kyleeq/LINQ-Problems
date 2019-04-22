using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQworksheet
{
    public class Problems
    {
        public List<string> words;
        public List<string> names;

        public Problems()
        {
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        }


        public void WordsThatContainTh(List<string> words)
        {
            List<string> wordsWithTh = new List<string>();
            foreach (string word in words)
            {
                if (word.Contains("th") == true)
                {
                    wordsWithTh.Add(word);
                    Console.WriteLine(word);
                }
            }
        }

        public void WordsThatContainThWithLINQ(List<string> words)
        {
            List<string> wordWithTh = new List<string>();
            var wordsWithTh = words.Where(w => w.Contains("th")).ToList();
            foreach(string word in words)
            {
                wordsWithTh.Add(word);
                Console.WriteLine(word);
            }
        }

        public void NamesWithoutRepeats()
        {

        }
    }
}
