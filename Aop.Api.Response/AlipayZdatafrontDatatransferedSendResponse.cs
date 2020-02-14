using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayZdatafrontDatatransferedSendResponse : AopResponse
	{
		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}
	}
}
