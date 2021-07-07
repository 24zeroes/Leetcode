using System;
using System.Collections.Generic;

namespace ExpressionInterpreter.App
{
    public class Expression : IExpression
    {
        private OperationsEnum Operation { get; set; }
        private Argument[] Arguments { get; set; }

        public Expression(Argument[] arguments, OperationsEnum operation)
        {
            Operation = operation;
            Arguments = arguments;
        }

        public int GetExpressionResult()
        {
            switch (Operation)
            {
                case OperationsEnum.Addition:
                    return Arguments[0].Value + Arguments[1].Value;
                case OperationsEnum.Division:
                    return Arguments[0].Value / Arguments[1].Value;
                case OperationsEnum.Multiplication:
                    return Arguments[0].Value * Arguments[1].Value;
                case OperationsEnum.Subtraction:
                    return Arguments[0].Value - Arguments[1].Value;
                default:
                    throw new Exception($"Unexpected operation type {Operation}");
            }
        }
    }
}