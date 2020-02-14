using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdAlipaySecurityProdTestResponse : AopResponse
	{
		[XmlElement("admin")]
		public string Admin
		{
			get;
			set;
		}
	}
}
