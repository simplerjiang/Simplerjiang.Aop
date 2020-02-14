using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoAutoinsprodCommonConsultResponse : AopResponse
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}
	}
}
