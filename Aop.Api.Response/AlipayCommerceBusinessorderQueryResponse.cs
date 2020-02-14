using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceBusinessorderQueryResponse : AopResponse
	{
		[XmlElement("record_detail")]
		public string RecordDetail
		{
			get;
			set;
		}
	}
}
