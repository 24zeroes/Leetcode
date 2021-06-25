using System;

namespace ExpressionInterpreter.App
{
    public class ExpressionInterpreter : IExpressionInterpreter
    {
        private readonly StringToExpressionParser _parser;
        private readonly string _input;
        public ExpressionInterpreter(string input)
        {
            _parser = new StringToExpressionParser();
            _input = input;
        }

        public int Calculate()
        {
            var result = 0;
            foreach (var expression in _parser.Parse(_input))
            {
                result = expression.GetExpressionResult();
                Console.WriteLine(result);
            }

            return result;
        }
    }
}