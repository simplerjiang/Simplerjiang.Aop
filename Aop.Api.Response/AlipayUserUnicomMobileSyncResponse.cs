using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserUnicomMobileSyncResponse : AopResponse
	{
		[XmlElement("mobile_sync_result")]
		public string MobileSyncResult
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}
	}
}
