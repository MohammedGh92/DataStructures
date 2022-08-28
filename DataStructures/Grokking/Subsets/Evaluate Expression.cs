using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Grokking.Subsets
{
    public class Evaluate_Expression
    {
        string str;
        public Evaluate_Expression()
        {
            //str = "2*3-4-5";
            str = "1+2*3";
        }

        public List<int> diffWaysToEvaluateExpression(string input)
        {
            List<int> result = new List<int>();
            if (!input.Contains("+") && !input.Contains("-") && !input.Contains("*"))
                result.Add(int.Parse(input));
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char chr = input[i];
                    if (!char.IsDigit(chr))
                    {
                        List<int> leftParts = diffWaysToEvaluateExpression(input.Substring(0, i));
                        List<int> rightParts = diffWaysToEvaluateExpression(input.Substring(i + 1));
                        foreach (int part1 in leftParts)
                        {
                            foreach (int part2 in rightParts)
                            {
                                if (chr == '+')
                                    result.Add(part1 + part2);
                                else if (chr == '-')
                                    result.Add(part1 - part2);
                                else if (chr == '*')
                                    result.Add(part1 * part2);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}