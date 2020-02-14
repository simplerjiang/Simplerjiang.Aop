using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaDataMorseOperateSyncResponse : AopResponse
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("result_extent")]
		public string ResultExtent
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
