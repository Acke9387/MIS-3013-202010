using System;

namespace Classes_TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox txt1 = new TextBox();
            txt1.BackColor = ConsoleColor.Green;
            txt1.ForeColor = ConsoleColor.Magenta;
            txt1.Text = "Hello World!";
            txt1.Padding = 5;

            TextBox txt2 = new TextBox();
            txt2.BackColor = ConsoleColor.Magenta;
            txt2.ForeColor = ConsoleColor.Green;
            txt2.Text = "Goodbye!";
            txt2.Padding = 1;

            txt1.DisplayText();
            txt2.DisplayText();

            Console.ReadKey();
        }
    }
}
