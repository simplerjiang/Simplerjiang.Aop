using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayBossCsCssocialYqmessageQueryModel : AopObject
	{
		[XmlElement("search_criteria")]
		public string SearchCriteria
		{
			get;
			set;
		}
	}
}
