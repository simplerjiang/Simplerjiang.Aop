using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduKtParentQueryResponse : AopResponse
	{
		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
