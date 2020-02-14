using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceCityfacilitatorScriptQueryResponse : AopResponse
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}
	}
}
