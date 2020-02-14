using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskHideDeviceidQueryResponse : AopResponse
	{
		[XmlElement("deviceid")]
		public string Deviceid
		{
			get;
			set;
		}
	}
}
