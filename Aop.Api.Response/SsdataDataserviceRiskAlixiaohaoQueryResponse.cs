using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskAlixiaohaoQueryResponse : AopResponse
	{
		[XmlElement("is_alixiaohao")]
		public bool IsAlixiaohao
		{
			get;
			set;
		}
	}
}
