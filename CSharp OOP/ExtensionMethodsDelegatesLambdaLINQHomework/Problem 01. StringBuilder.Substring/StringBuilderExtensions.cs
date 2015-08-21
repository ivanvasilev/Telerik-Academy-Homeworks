namespace StringBuilderExtensions
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        // Extension Methods
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(input[index]);
                index++;
            }
            return result;
        }

        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < input.Length; i++)
            {
                result.Append(input[index]);
                index++;
            }
            return result;
        }
    }
}
