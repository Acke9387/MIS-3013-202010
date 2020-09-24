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
            // Starting value | Condition to loop      | what assignment happens after each loop
            //                                          this could be i = i + 10 to count by 10 each loop
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
