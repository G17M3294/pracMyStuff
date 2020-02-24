using System;

namespace Problems
{
    public class Program
    {	  		
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
			Prefix(input);				
        }

         Prefix(string input)
        {
            int stringLength = input.length;
            int a = 0, myWord = 1;

            while (a <= input.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    myWord++;
                }
                a++;
            }
            Console.Write(stringLength + ",", myWord + input);
        }
    }
}
