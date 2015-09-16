using System;
using System.Text;

namespace PharmacyConditionServer
{
	public static class Password
	{
		public static string Encrypt(string text)
		{
			var byteArrayFromString = Encoding.ASCII.GetBytes(text);

			return Convert.ToBase64String(byteArrayFromString);
		}

		public static string Decrypt(string text)
		{
			var byteArrayFromString = Convert.FromBase64String(text);

			return Encoding.ASCII.GetString(byteArrayFromString);
		}
	}
}