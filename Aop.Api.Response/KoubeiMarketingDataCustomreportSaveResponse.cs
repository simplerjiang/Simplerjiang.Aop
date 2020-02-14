using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataCustomreportSaveResponse : AopResponse
	{
		[XmlElement("condition_key")]
		public string ConditionKey
		{
			get;
			set;
		}
	}
}
