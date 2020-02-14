using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceHellobikeLogSyncResponse : AopResponse
	{
		[XmlElement("biz_code")]
		public string BizCode
		{
			get;
			set;
		}
	}
}
