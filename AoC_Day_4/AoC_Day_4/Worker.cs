using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC_Day_4 {
    internal class Worker {

        int[] rangeOne, rangeTwo;

        public Worker() {
        }

        public int partOneParseLine(string line) {
            int result = 0;

            string[] commaSplit = line.Split(",");
            string[] rangeOneSplit = commaSplit[0].Split("-");
            string[] rangeTwoSplit = commaSplit[1].Split("-");

            rangeOne = new int[] { Int32.Parse(rangeOneSplit[0]), Int32.Parse(rangeOneSplit[1]) };
            rangeTwo = new int[] { Int32.Parse(rangeTwoSplit[0]), Int32.Parse(rangeTwoSplit[1]) };

            int[] bothRanges = new int[] { Int32.Parse(rangeOneSplit[0]), Int32.Parse(rangeOneSplit[1]), Int32.Parse(rangeTwoSplit[0]), Int32.Parse(rangeTwoSplit[1]) };

            Array.Sort(bothRanges);


            if ((rangeTwo.Max() >= rangeOne.Max() && rangeTwo.Min() <= rangeOne.Min()) || (rangeOne.Max() >= rangeTwo.Max() && rangeOne.Min() <= rangeTwo.Min())) {
                result = 1;
            }

            return result;
        }

        public int partTwoParseLine() {
            int result = 0;

            IEnumerable<int> range_one = Enumerable.Range(rangeOne.Min(), (rangeOne.Max() - rangeOne.Min() + 1));
            IEnumerable<int> range_two = Enumerable.Range(rangeTwo.Min(), (rangeTwo.Max() - rangeTwo.Min() + 1));
            List<int> rangerOne = new List<int>();
            List<int> rangerTwo = new List<int>();

            if (range_one.Intersect<int>(range_two).Any() || range_one.Intersect<int>(range_two).Any()) {
                result = 1;
            }



            return result;
        }
    }
}
