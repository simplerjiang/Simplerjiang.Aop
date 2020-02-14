using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskBackgroundInterfaceQueryResponse : AopResponse
	{
		[XmlElement("detail_info")]
		public string DetailInfo
		{
			get;
			set;
		}
	}
}
