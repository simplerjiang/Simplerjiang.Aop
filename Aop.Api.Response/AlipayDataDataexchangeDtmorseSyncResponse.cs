using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataexchangeDtmorseSyncResponse : AopResponse
	{
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
