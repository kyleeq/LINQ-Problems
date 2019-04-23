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
        public List<string> grades;

        public Problems()
        {
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            grades = new List<string>() {"80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55"};
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
            var wordsWithTh = words.Where(w => w.Contains("th")).ToList();
            foreach(string word in wordsWithTh)
            {
                Console.WriteLine(word);
            }
        }

        public void NamesWithoutRepeat(List<string> names)
        {
            List<string> namesWithoutRepeat = new List<string>();
            
            foreach (string name in names)
            {
               if (namesWithoutRepeat.Contains(name) == false)
                {
                    namesWithoutRepeat.Add(name);
                    Console.WriteLine(name);
                }
            }
        }

        public void NamesWithoutRepeatsWithLINQ(List<string> names)
        {
            var namesWithoutRepeat = names.Distinct().ToList();
            foreach (string name in namesWithoutRepeat)
            {
                Console.WriteLine(name);
            }
        }

        public void AverageGrade(List<string> grades)
        {
            var stringArray = grades.Select(g => g.Split(',')).ToList();
            var intList = stringArray.Select(g => g.Select(a => int.Parse(a)).ToList()).ToList();
            // remove lowest
            // add all values in sub arrays and divide by grades.Count
            // add averages and divide by averages.Count
        }
        public void AlphabeticOrder(string word)
        {
            var alphabeticString = word.ToUpper().ToCharArray();
            var wordArray = alphabeticString.GroupBy(j => j).ToDictionary(j => j.Key, j => j.Count()).OrderBy(j => j.Key); 
            foreach (KeyValuePair<char,int> character in wordArray)
            {
                Console.Write(""+character.Key + character.Value);
            }
        }
    }
}
