using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileDeviceinfoGetidbytokenResponse : AopResponse
	{
		[XmlElement("apdid")]
		public string Apdid
		{
			get;
			set;
		}

		[XmlElement("operateresult")]
		public bool Operateresult
		{
			get;
			set;
		}

		[XmlElement("umid")]
		public string Umid
		{
			get;
			set;
		}
	}
}
