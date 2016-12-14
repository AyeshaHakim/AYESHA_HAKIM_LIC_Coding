// Program developed by Ayesha Hakim for LIC conding test (14-12-2016)
// Git repo: https://github.com/AyeshaHakim/AYESHA_HAKIM_LIC_Coding
using System;
namespace LIC_Coding
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string key="";
			PalindromeClass cls_palindrome = new PalindromeClass();
			while (key != "n")
			{
				Console.WriteLine("\n*** Enter a String ***\n");
				Console.WriteLine("Instructions:");
				Console.WriteLine("There should be no whitespace in the string");
				Console.WriteLine("All characters in the string must be lower case");
				Console.WriteLine("The string will only contain alpha characters a-z \n");
				String s = Console.ReadLine();

				while (!cls_palindrome.is_invalidString(s))
				{
					Console.WriteLine("Please enter a valid string \n");
					s = Console.ReadLine();
				}

				if (cls_palindrome.is_palindrome(s))
					Console.WriteLine("String is a Palindrome \n");
				if (cls_palindrome.is_anagram(s))
					Console.WriteLine("String is an Anagram of a Palindrome \n");
				if(!cls_palindrome.is_palindrome(s) && !cls_palindrome.is_anagram(s))
					Console.WriteLine("String is neither a Palindrome nor an Anagram of a Palindrome \n");
				
				Console.WriteLine("Do you want to continue? Press 'y' for YES and 'n' for NO");

				key=Console.ReadKey().KeyChar.ToString();
			}
		}
	}
}