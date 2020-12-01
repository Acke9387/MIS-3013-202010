using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_TextBox
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }

        public TextBox()
        {
            Padding = 5; //Default should be 5 because there should always be 5 for padding unless otherwise
            BackColor = ConsoleColor.Black;
            ForeColor = ConsoleColor.White;
            Text = string.Empty;
        }

        public void DisplayText()
        {
            string output = "";
            string padding = "";
            // First way to get the padding
            for (int i = 0; i < Padding; i++)
            {
                padding += " ";
            }
            output = $"{padding}{Text}{padding}";

            // Second way to get the padding
            output = Text.PadLeft(Text.Length + Padding);
            output = output.PadRight(output.Length + Padding);

            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            Console.WriteLine(output);
        }

    }
}
