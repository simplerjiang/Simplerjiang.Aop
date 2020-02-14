using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayZdataassetsEasyserviceResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
