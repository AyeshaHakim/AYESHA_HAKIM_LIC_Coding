// Program developed by Ayesha Hakim for LIC conding test
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AYESHA_HAKIM_LIC_Coding
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string key="";
			palindrome pal = new palindrome();
			while (key != "n")
			{
				Console.WriteLine("\n*** Enter a String ***\n");
				Console.WriteLine("Instructions:");
				Console.WriteLine("There should be no whitespace in the string");
				Console.WriteLine("All characters in the string must be lower case");
				Console.WriteLine("The string will only contain alpha characters a-z \n");
				String s = Console.ReadLine();

				while (!pal.is_invalidString(s))
				{
					Console.WriteLine("Please enter a valid string \n");
					s = Console.ReadLine();
				}

				if (pal.is_palindrome(s))
					Console.WriteLine("String is a Palindrome \n");
				if (pal.is_anagram(s))
					Console.WriteLine("String is an Anagram of a Palindrome \n");
				if(!pal.is_palindrome(s) && !pal.is_anagram(s))
					Console.WriteLine("String is neither a Palindrome nor an Anagram of a Palindrome \n");
				
				Console.WriteLine("Do you want to continue? Press 'y' for YES and 'n' for NO");

				key=Console.ReadKey().KeyChar.ToString();
			}
		}
	}
	class palindrome
	{
		// Check whether the entered string is valid
		public bool is_invalidString(String str)
		{
			Regex r = new Regex("^[a-z]*$");
			if (str.Length == 0)
				return false;
			else
			{
				if (r.IsMatch(str))
					return true;
				else
					return false;
			}
		}
		// Check whether a string is a palindrome
		public bool is_palindrome(String s)
		{
			String revs = "";
			var length = s.Length;

			for (int i = length - 1; i >= 0; i--) //String Reverse
			{
				revs += s[i].ToString();
			}
			if (revs == s)
				return true;
			else
				return false;
		}
		// Check whether a string is an anagram of a palindrome
		public bool is_anagram(String s)
		{
			var length = s.Length;
			var dic = new Dictionary<char, int>();
			for (int i = 0; i < length; i++)
			{
				if (dic.ContainsKey(s[i]))
				{
					dic[s[i]]++;
					continue;
				}

				dic.Add(s[i], 1);
			}
			int odd = 0;
			foreach (var pv in dic)
			{
				if (pv.Value % 2 != 0)
					odd++;
			}
			if (odd > 1)
				return false;
			else
			return true;
		}

	}
}