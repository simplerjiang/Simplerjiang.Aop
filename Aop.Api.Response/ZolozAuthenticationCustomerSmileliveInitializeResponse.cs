using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozAuthenticationCustomerSmileliveInitializeResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
