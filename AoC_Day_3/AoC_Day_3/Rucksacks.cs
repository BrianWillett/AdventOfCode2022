using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Day_3 {
    internal class Rucksacks {

        string compartmentOne, compartmentTwo, compartmentThree;
        Dictionary<string, int> alphaValues = new Dictionary<string, int>();

        public Rucksacks() {
                initializeDictionaryValues();           
        }

        public void initializeDictionaryValues() {

            var alphabet = JsonConvert.DeserializeObject<List<Alphabet>>(File.ReadAllText(@"D:\Repos\AdventOfCode2022\AoC_Day_3\AoC_Day_3\alphabet.json"));

            foreach (var letter in alphabet) {
                alphaValues.Add(letter.Letter, letter.Value);
            }
        }

        public int doWork(List<string> rucksack) {
            this.compartmentOne = rucksack[0];
            this.compartmentTwo = rucksack[1];
            int result = 0;

            List<int> compartOne = new List<int>();
            List<int> compartTwo = new List<int>();

            foreach (Char letter in compartmentOne) {
                 compartOne.Add(alphaValues[letter.ToString()]);
            }
            foreach (Char letter in compartmentTwo) {
                compartTwo.Add(alphaValues[letter.ToString()]);
            }

            foreach (int value in compartOne) {
                int found = compartTwo.Find(x => x == value);
                if (found > 0) {
                    return found;
                }

            }
            return result;
        }

        public int doPart2Work(List<string> ruckSack) {
            this.compartmentOne = ruckSack[0];
            this.compartmentTwo = ruckSack[1];
            this.compartmentThree = ruckSack[2];
            int result = 0;

            foreach (string line in ruckSack) {
                Console.WriteLine(line);
            }

            List<int> compartOne = new List<int>();
            List<int> compartTwo = new List<int>();
            List<int> compartThree = new List<int>();

            foreach (Char letter in compartmentOne) {
                compartOne.Add(alphaValues[letter.ToString()]);
            }
            foreach (Char letter in compartmentTwo) {
                compartTwo.Add(alphaValues[letter.ToString()]);
            }
            foreach (Char letter in compartmentThree) {
                compartThree.Add(alphaValues[letter.ToString()]);
            }

            foreach (int value in compartOne) {
                int found = compartTwo.Find(x => x == value) & compartThree.Find(x => x == value);
                if (found > 0) {
                    //Console.WriteLine(found.ToString() + " - " + getLetterFromValue(found));
                    Console.WriteLine("---------------------------------");
                    return found;
                }

            }
            return result;
        }

        private string getLetterFromValue(int val) {
            return alphaValues.FirstOrDefault(x => x.Value == val).Key;
        }
    }
}
