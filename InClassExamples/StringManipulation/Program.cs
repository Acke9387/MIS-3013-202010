using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //                         012345678910
            string instanceOfString = "Hello World!";

            instanceOfString = instanceOfString.ToUpper();
            for (int i = 0; i < instanceOfString.Length; i++)
            {
                char letter = instanceOfString[i];
                // Have to conver the CHARACTER to a string to use the String methods
                Console.WriteLine(letter);//.ToString().ToUpper());

            }


            Console.ReadKey();
        }
    }
}
