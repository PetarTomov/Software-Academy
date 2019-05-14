using System;
using System.Collections.Generic;
using System.Linq;

class MatchingBrackets
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = IsValid(input) ? "Valid" : "Invalid";
        Console.WriteLine(result);
    }

    private static bool IsValid(string input)
    {
        Dictionary<char, char> bracketsCouples = new Dictionary<char, char>();
        string openingBrackets = "([{";
        string allBrackets = "(){}[]";

        if (!openingBrackets.Contains(input[0]))
        {
            return false;
        }

        bracketsCouples.Add(')', '(');
        bracketsCouples.Add(']', '[');
        bracketsCouples.Add('}', '{');

        Stack<char> brackets = new Stack<char>();

        foreach (var symbol in input.Where(s => allBrackets.Contains(s)))
        {
            if (openingBrackets.Contains(symbol))
            {
                brackets.Push(symbol);
            }
            else
            {
                if (brackets.Pop() != bracketsCouples[symbol])
                {
                    return false;
                }
            }
        }

        if (brackets.Count == 0)
        {
            return true;
        }

        return false;
    }
}