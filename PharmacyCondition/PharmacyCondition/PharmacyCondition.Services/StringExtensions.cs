namespace PharmacyCondition.Services
{
	public static class StringExtensions
	{
		public static string MakeItClean(this string barcode, string prefix)
		{
			var tempBarcode = string.IsNullOrEmpty(prefix) ? barcode : barcode.Substring(1, barcode.Length - 1);

			//barcode checkings for delivery code
			if(tempBarcode[0] == '2' || tempBarcode[0] == '9')
			{
				return tempBarcode.Remove(tempBarcode.Length - 1, 1);
			}
			return tempBarcode;
		}
	}
}