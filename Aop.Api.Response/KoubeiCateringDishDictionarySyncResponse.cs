using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishDictionarySyncResponse : AopResponse
	{
		[XmlElement("dictionary_id")]
		public string DictionaryId
		{
			get;
			set;
		}
	}
}
