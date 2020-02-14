using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoRenthouseRenterZhimaQueryResponse : AopResponse
	{
		[XmlElement("status_value")]
		public string StatusValue
		{
			get;
			set;
		}
	}
}
