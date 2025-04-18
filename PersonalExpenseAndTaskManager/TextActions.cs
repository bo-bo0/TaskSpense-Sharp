using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseAndTaskManager
{
    internal abstract class TextActions
    {
        public static void inputBlock(TextBox textBox, int maxLength)
        {
            if (textBox.Text.Length > maxLength)
            {
                var newText = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.Text = newText;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        public static bool spacesString(string text)
        {
            //if first character is empty return true

            if (text.Length > 0) //check if the string has characters
            {
                if (text[0] == ' ')
                    return true;
            }

            //if at least a character is not empty return true
            foreach (var character in text)
            {

                if (character != ' ')
                    return false;

            }

            return true; //if all characters are empty return true

        }

        public static string specialCharactersClean(string text) 
        {
            var sb = new StringBuilder();

            foreach (var character in text)
            {
                if (character == '\n')
                    sb.Append("\\n");
                else if (character == '\\')
                    sb.Append("\\\\");
                else if (character == '"')
                    sb.Append("\\\"");
                else
                    sb.Append(character);
            }

            return sb.ToString();
        }
    }
}
