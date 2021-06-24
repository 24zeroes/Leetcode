using System;

namespace ExpressionInterpreter.App
{
    public class ExpressionInterpreter : IExpressionInterpreter
    {
        private readonly StringToExpressionParser Parser;
        private readonly string Input;
        public ExpressionInterpreter(string input)
        {
            Parser = new StringToExpressionParser();
            Input = input;
        }

        public int Calculate()
        {
            var result = 0;
            foreach (var expression in Parser.Parse(Input))
            {
                result = expression.GetExpressionResult();
                Console.WriteLine(result);
            }

            return result;
        }
    }
}