using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayBossProdArrangementOfflineQueryResponse : AopResponse
	{
		[XmlElement("sign_status")]
		public string SignStatus
		{
			get;
			set;
		}
	}
}
