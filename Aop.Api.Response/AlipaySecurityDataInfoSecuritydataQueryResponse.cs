using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityDataInfoSecuritydataQueryResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
