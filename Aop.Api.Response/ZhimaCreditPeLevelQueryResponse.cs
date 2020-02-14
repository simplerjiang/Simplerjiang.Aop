using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditPeLevelQueryResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("level_code")]
		public string LevelCode
		{
			get;
			set;
		}

		[XmlElement("level_name")]
		public string LevelName
		{
			get;
			set;
		}
	}
}
