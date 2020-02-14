using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishDictionaryQueryResponse : AopResponse
	{
		[XmlArray("kb_dish_dictionary_list")]
		[XmlArrayItem("kbdish_dictionary")]
		public List<KbdishDictionary> KbDishDictionaryList
		{
			get;
			set;
		}
	}
}
