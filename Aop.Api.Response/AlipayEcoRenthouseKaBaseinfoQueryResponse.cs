using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoRenthouseKaBaseinfoQueryResponse : AopResponse
	{
		[XmlElement("ka_code")]
		public string KaCode
		{
			get;
			set;
		}

		[XmlElement("ka_name")]
		public string KaName
		{
			get;
			set;
		}

		[XmlElement("valid")]
		public string Valid
		{
			get;
			set;
		}
	}
}
