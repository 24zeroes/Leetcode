namespace ExpressionInterpreter.App
{
    public static class CharExtentions
    {
        public static bool IsNumeric(this char c)
        {
            switch (c)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    return true;
                default:
                    return false;
            }
        }
    }
}