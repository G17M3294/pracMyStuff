using System;

namespace Problems
{
    public class Program
    {
		Prefix(string input)
		{//do it propper
			int[] numWords = input.split(" ");
			int stringLength = input.length;
			
			
			string result = stringLength.toString() + "," + numWords.toString() + input;
			return result;
		}
		
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
