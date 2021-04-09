using System;

namespace recursion
{

    
    public enum Operator
    {
        Add,
        Subtract,
        Divide,
        Multiply
    }
    public class Program
    {
        public static string equation;
        public static string originalEquation ;

        
        public static Operator op;

        //public static var operation = new Operation(); //Somehow call new Operation?
        public static void Main(string[] args)
        {
            
            equation = "5*(((4+3)*2)+7)"; 
            originalEquation = equation;
            Console.WriteLine(equation);
            string solution = Solve(equation);
            Console.WriteLine(originalEquation);
            Console.WriteLine(solution);
        }
        
        public static string Solve (string equation) 
        //Starts the Recursion
        {
            string subEquation = " ";
            if (equation.Contains("("))
            {
                int startBracket = equation.IndexOf('('); 
                int endBracket = equation.LastIndexOf(')');
                int subLength =endBracket - startBracket ;
                subEquation = equation.Substring(startBracket + 1, subLength - 1);
                Console.WriteLine(subEquation);
                return Solve(subEquation);
            }
            else
            {
                double sum = Calculate(equation);
                if (originalEquation.Contains("("))
                {

                    equation = originalEquation.Replace($"({equation})", sum.ToString());
                    //replaces the part of the equation with the solved sum inside the brackets.
                }
                else
                {
                     equation = originalEquation.Replace($"{equation}", sum.ToString());
                     //replaces the equation with the full calculation once there are no longer any brackets to solve through.
                }
                originalEquation = equation;
                Console.WriteLine($"New Equation {equation}");
                if (equation.Contains("+") || equation.Contains("-") || equation.Contains("/") || equation.Contains("*"))
                {

                    Solve(equation);
                }
            }



          

            return subEquation;
        }

        public static double Calculate(string equation)
        {
             int index = 0;
                

               if (equation.Contains("+"))
                    {
                        op = Operator.Add;
                        index = equation.LastIndexOf(@"+");
                      
                    }

                if (equation.Contains("*"))
                    {
                        op = Operator.Multiply;
                        index = equation.LastIndexOf(@"*");
                        
                    }
                
                if (equation.Contains("/"))
                    {
                        op = Operator.Divide;
                        index = equation.LastIndexOf(@"/");
                        
                    }

                if (equation.Contains("-"))
                    {
                        op = Operator.Subtract;
                        index = equation.LastIndexOf(@"-");
                        
                    }



            double sum = 0;

            string left = equation.Substring(0, index);
            int rightSub = (equation.Length - 1) - index;
            string right = equation.Substring(index + 1, rightSub);
            //splits the equation either side of the operator. 


            switch (op)
            {
                case Operator.Add:
                    sum = Convert.ToInt32(left) + Convert.ToInt32(right);
                    break;

                case Operator.Multiply:
                    sum = Convert.ToInt32(left) * Convert.ToInt32(right);
                    break;
                
                case Operator.Divide:
                    sum = Convert.ToInt32(left) / Convert.ToInt32(right);
                    break;
                
                case Operator.Subtract:
                    sum = Convert.ToInt32(left) - Convert.ToInt32(right);
                    break;

            }

            Console.WriteLine($"Sum: {sum}");
            return sum;
        }      
        
        
    }
}

