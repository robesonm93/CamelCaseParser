using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CamelCaseParser
{
	public class CamelCaseParser
	{
		public string parseCamelCase(string text)
		{
			string formatedString = "";
			for (int i = 0; i < text.Length; i++)
			{
				char character = text[i];
				if (i == 0)
				{
					formatedString += character;
				}
				else
				{
					if (char.IsUpper(character))
					{
						formatedString += " " + character.ToString().ToLower();
					}
					else
					{
						formatedString += character;
					}
				}
			}
			return formatedString;
		}
	}
}