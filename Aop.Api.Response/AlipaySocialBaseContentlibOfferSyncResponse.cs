using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseContentlibOfferSyncResponse : AopResponse
	{
		[XmlElement("content")]
		public string Content
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
