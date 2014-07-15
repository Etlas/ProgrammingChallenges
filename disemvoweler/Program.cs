using System;
using System.Linq;

namespace Disemvoweler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] vowels = new char[] {'a','e','i','o','u',' '};
			string word;
			Console.WriteLine ("The Disemvoweler - 7/4/2014");
			Console.WriteLine ("The Disemvoweler will take any string, strip it of its vowels");
			Console.WriteLine("and spaces and spit it back in your face.");
			Console.WriteLine ("");
			Console.WriteLine ("Enter the string: ");
			word = Console.ReadLine ();	
			char[] letters = word.ToCharArray();
			string result = "";
			string voweled = "";

				foreach (char c in word)
				{	
				if (vowels.Contains (c)) {
					if (c != ' ') {
						voweled = voweled + c;
					} 
				} else {
						result = result + c;
						}
					}
			Console.WriteLine ("");
			Console.WriteLine ("Result: "+result);
			Console.WriteLine ("Vowels: "+voweled);
			Console.ReadLine ();

			}
		}
		
	}
