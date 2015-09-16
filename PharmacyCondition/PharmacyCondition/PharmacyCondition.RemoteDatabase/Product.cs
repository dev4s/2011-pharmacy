using System.Runtime.Serialization;

namespace PharmacyCondition.RemoteDatabase
{
    [DataContract]
    public class Product
    {
        [DataMember] public int ID { set; get; }
        [DataMember] public string Name { set; get; }
        [DataMember] public BarcodeTypes BarcodeType { set; get; }
        [DataMember] public string CleanBarcode { set; get; }
		[DataMember] public string DirtyBarcode { set; get; }
    }

    [DataContract]
    public enum BarcodeTypes
    {
        [EnumMember] Delivery,		//dostępny i jest to kod wewnętrzny (kod w bazie)
        [EnumMember] Ean,			//dostępny i jest to kod ean (kod w bazie)
        [EnumMember] NotExisting,	//niedostępny, nie ma produktu o takim kodzie (nie ma kodu w bazie)
        [EnumMember] Selled			//niedostępny, jest produkt o takim kodzie (kod w bazie)
    }
}