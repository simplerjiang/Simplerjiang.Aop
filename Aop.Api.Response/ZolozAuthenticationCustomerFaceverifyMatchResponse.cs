using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozAuthenticationCustomerFaceverifyMatchResponse : AopResponse
	{
		[XmlElement("attack")]
		public bool Attack
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
