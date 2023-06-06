using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceCombinationFinder
{
    public class Output
    {
        public string Out { get; set; }
        public List<int> Filter { get; set; } = new List<int>();
    }

    class NumberFunctions
    {
        public static List<Output> GetFastCombinations(int roll, List<int> faces, List<int> sums)
        {
            if (sums.All(s=>s<0) || sums.All(s=> roll * faces.Max()< s) || sums.All(s=>roll> s))
                return new List<Output>();

            return faces.DifferentCombinations(roll).Select(combs =>
            {
                var whichSum = sums.Where(s => combs.Sum() == s).ToList();

                if (whichSum.Count == 0)
                    return null;

                var outCombs = new List<int>();
                string number = "";
                string outputString = "";
                int index = 1;
                foreach(var comb in combs)
                {
                    outCombs.Add(comb);
                    outputString += outputString == "" ? ($"D{index++}=" + comb) : ( $" + D{index++}=" + comb); 
                }

                return new Output { 
                    Out  = outputString,
                    Filter = outCombs, 
                };

                //return outcombs + " = "+ whichSum[0];

            }).Where(s=>s!=null).ToList();
        }

        


        public static int GetCombinations(int roll, List<int> faces, int sum, List<int> done, ref List<string> output, string combs = "")
        {
            if (roll == 0)
            {
                if (sum == 0)
                {
                    output.Add(combs);
                    return 1;
                }

                return 0;
            }


            if (sum < 0 || roll * faces.Max() < sum || roll > sum)
                return 0;

            int res = 0;

            foreach (int face in faces)
            {
                if (done.Contains(face))
                    continue;
                done.Add(face);
                res += GetCombinations(roll - 1, faces, sum - face, done, ref output, combs.Equals("") ? "D" + face : combs + "+ D" + face);
                done.Remove(face);
            }

            return res;
        }

        public static List<int> Parse(string s)
        {
            string[] pieces = s.Split(',');
            pieces = pieces.Select(x => x.Trim()).ToArray();
            pieces = pieces.OrderByDescending(x => x).ToArray();

            List<int> numbers = new List<int>();

            foreach (string piece in pieces)
            {
                if (piece.Trim().StartsWith("#"))
                {
                    if (piece.Contains("-"))
                    {
                        List<int> i = ParseRange(piece.Substring(1));
                        if (i != null)
                            foreach (int i1 in i)
                            {
                                numbers.Remove(i1);
                            }
                    }
                    else
                    {
                        int num = ParseNumber(piece.Substring(1));
                        numbers.Remove(num);
                    }
                }
                else if (piece.Trim().Contains("-"))
                {
                    List<int> i = ParseRange(piece);
                    if(i != null)
                        numbers.AddRange(i);
                }
                else
                {
                    int num = ParseNumber(piece);

                    if(num > 0)
                        numbers.Add(num);
                }
            }

            return numbers;
        }

        private static int ParseNumber(string s)
        {
            try
            {
                int n = Convert.ToInt16(s.Trim());
                return n;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        private static List<int> ParseRange(string s)
        {
            string[] numbers = s.Split('-');

            if (numbers.Length != 2)
                return null;

            try
            {
                int num1 = Convert.ToInt16(numbers[0].Trim());
                int num2 = Convert.ToInt16(numbers[1].Trim());

                if (num1 >= num2)
                    return null;

                List<int> output = new List<int>();

                for (int x = num1; x <= num2; x++)
                {
                    output.Add(x);
                }

                return output;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
