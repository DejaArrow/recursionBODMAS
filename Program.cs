using System;

namespace recursion
{

    public enum Operation
    {
        None,
        Add,
        Subtract,
        Divide,
        Multiply
        

    }
    class Program
    {
        public string equation;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter equation: ");
            equation = Console.ReadLine(); // Gets equation from user and stores it in string.
        }
        
        public static string Solve (string equation)
        {
            string subEquation = " ";
            if (equation.Contains("("))
            {
                int startBracket = equation.IndexOf('(');
                int endBracket = equation.LastIndexOf(')');
                int subLength = startBracket - endBracket;
                subEquation = equation.Substring(startBracket + 1, subLength - 1);
                Console.WriteLine(subEquation);
                return Solve(subEquation);
            }
            Console.WriteLine(equation);

            

            return equation;
        }
        public static double evaluate
        
        private Operation GetOperationType(char character)
        {
            switch (operation.Operation)
                {
                    case Operation.Add:
                        return (left + right).ToString();
                    case Operation.Minus:
                        return (left - right).ToString();
                    case Operation.Divide:
                        return (left / right).ToString();
                    case OperationMultiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. { operation.Operation }");
                }
        }
    }
}

