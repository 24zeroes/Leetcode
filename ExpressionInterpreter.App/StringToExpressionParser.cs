using System;
using System.Collections.Generic;

namespace ExpressionInterpreter.App
{
    public class StringToExpressionParser
    {
        private Dictionary<char, CharacterTypeEnum> AllowedCharactersToType => new Dictionary<char, CharacterTypeEnum>
        {
            {'1', CharacterTypeEnum.Numeric},
            {'2', CharacterTypeEnum.Numeric},
            {'3', CharacterTypeEnum.Numeric},
            {'4', CharacterTypeEnum.Numeric},
            {'5', CharacterTypeEnum.Numeric},
            {'6', CharacterTypeEnum.Numeric},
            {'7', CharacterTypeEnum.Numeric},
            {'8', CharacterTypeEnum.Numeric},
            {'9', CharacterTypeEnum.Numeric},
            {'0', CharacterTypeEnum.Numeric},
            {'+', CharacterTypeEnum.Operation},
            {'-', CharacterTypeEnum.Operation},
            {'*', CharacterTypeEnum.Operation},
            {'/', CharacterTypeEnum.Operation},
        };
        private OperationsEnum CurrentOperation { get; set; }
        private Argument[] CurrentArguments { get; set; }
        private int ArgumentsCounter { get; set; }

        private bool IsExpressionComplete =>
            ArgumentsCounter == 2 && CurrentOperation != OperationsEnum.Undefined;
        
        public IEnumerable<Expression> Parse(string input)
        {
            var left = 0;
            CurrentArguments = new Argument[2];
            CurrentOperation = OperationsEnum.Undefined;
            ArgumentsCounter = 0;

            while (left < input.Length)
            {
                var type = GetCharacterType(input[left]);


                if (type == CharacterTypeEnum.Unknown)
                {
                    throw new Exception($"Expression parsing Exception. Input contains unsupported symbol: {input[left]}");
                }

                if (CurrentOperation != OperationsEnum.Undefined && type == CharacterTypeEnum.Operation)
                {
                    throw new Exception($"Expression parsing Exception. Could not process more than one operation on step. Char index {left}, char {input[left]}");
                }

                if (type == CharacterTypeEnum.Operation)
                {
                    CurrentOperation = GetOperationFromCharacter(input[left]);
                    left += 1;
                }

                if (type == CharacterTypeEnum.Numeric)
                {
                    var result = GetNumberFromIndex(left, input);
                    CurrentArguments[ArgumentsCounter] = result.Item1;
                    ArgumentsCounter += 1;
                    left += result.Item2;
                }

                if (IsExpressionComplete)
                {
                    yield return new Expression(CurrentArguments, CurrentOperation);
                    CurrentArguments = new Argument[2];
                    CurrentOperation = OperationsEnum.Undefined;
                    ArgumentsCounter = 0;
                }
                
            }
        }

        private (Argument, int) GetNumberFromIndex(int left, string input)
        {
            var start = left;
            var size = 0;
            while (start + size < input.Length && input[start + size].IsNumeric())
            {
                size += 1;
            }

            var tmpString = input.Substring(start, size);

            int.TryParse(tmpString, out var resultNumber);
            
            return (new Argument(resultNumber), size);
        }

        private OperationsEnum GetOperationFromCharacter(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationsEnum.Addition;
                case '-':
                    return OperationsEnum.Subtraction;
                case '*': 
                    return OperationsEnum.Multiplication;
                case '/':
                    return OperationsEnum.Division;
                default:
                    return OperationsEnum.Undefined;
            }
        }

        private CharacterTypeEnum GetCharacterType(char character)
        {
            if (AllowedCharactersToType.TryGetValue(character, out var resultType))
            {
                return resultType;
            }

            return CharacterTypeEnum.Unknown;
        }
    }
}