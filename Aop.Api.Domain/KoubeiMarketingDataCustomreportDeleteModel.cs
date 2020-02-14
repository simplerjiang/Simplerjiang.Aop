using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataCustomreportDeleteModel : AopObject
	{
		[XmlElement("condition_key")]
		public string ConditionKey
		{
			get;
			set;
		}
	}
}
