using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoRenthouseKaBaseinfoSyncResponse : AopResponse
	{
		[XmlElement("ka_code")]
		public string KaCode
		{
			get;
			set;
		}
	}
}
