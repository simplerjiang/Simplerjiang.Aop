using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeNoticePublishResponse : AopResponse
	{
		[XmlElement("notice_id")]
		public string NoticeId
		{
			get;
			set;
		}
	}
}
