using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace LIC_Coding
{
	public class PalindromeClass
	{
		// Check whether the entered string is valid
		public bool is_invalidString(String str)
		{
			try
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
			catch(Exception ex)
			{
				Console.WriteLine("Something unexpected happened: {0}",ex.GetType());
				return false;
			}
		}
		// Check whether a string is a palindrome
		public bool is_palindrome(String s)
		{
			try
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
			catch (Exception ex)
			{
				Console.WriteLine("Something unexpected happened: {0}", ex.GetType());
				return false;
			}
		}
		// Check whether a string is an anagram of a palindrome
		public bool is_anagram(String s)
		{
			try
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
			catch (Exception ex)
			{
				Console.WriteLine("Something unexpected happened: {0}", ex.GetType());
				return false;
			}
		}

	}
}