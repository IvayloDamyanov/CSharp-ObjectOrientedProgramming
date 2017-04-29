using System;
using System.Text;

namespace StringBuilderSubstring
{
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder output = new StringBuilder();
            for (int i = index; i <= index + length; i++)
            {
                output.Append(sb[i]);
            }
            return output;
        }

    }
}
