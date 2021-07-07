namespace ExpressionInterpreter.App
{
    public class Argument
    {
        private ArgumentTypeEnum ArgumentType { get; set; }
        public int Value { get; set; }
        public Expression Reference { get; set; }

        public Argument(int value)
        {
            ArgumentType = ArgumentTypeEnum.Value;
            Value = value;
        }

        public Argument(Expression reference)
        {
            ArgumentType = ArgumentTypeEnum.Reference;
            Reference = reference;
        }
    }
}