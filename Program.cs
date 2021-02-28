using System;

namespace recursion
{

    public enum Operation
    {
        Add,
        Subtract,
        Divide,
        Multiply
        

    }
    class Program
    {
        public string equation;
        var operation = new Operation(); //Somehow call new Operation?
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter equation: ");
            equation = Console.ReadLine(); // Gets equation from user and stores it in string.
        }
        
        public static string Solve (string equation) //Starts the Recursion
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

            //Split -> string left, operatortype, string right -> call Operator to do the thing to return the sum of the subEquation? 
            
            return equation;
        }
        
        
        private Operation OperationType(char character)
        {
            switch (operation.Operation)
                {
                    case Operation.Add:
                        return (left + right).ToString(equation);
                    case Operation.Subtract:
                        return (left - right).ToString(equation);
                    case Operation.Divide:
                        return (left / right).ToString(equation);
                    case Operation.Multiply:
                        return (left * right).ToString(equation);
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. { operation.Operation }");
                }
        }
    }
}

