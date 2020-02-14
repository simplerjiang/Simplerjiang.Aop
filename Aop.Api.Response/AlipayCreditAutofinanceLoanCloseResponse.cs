using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCreditAutofinanceLoanCloseResponse : AopResponse
	{
		[XmlElement("outorderno")]
		public string Outorderno
		{
			get;
			set;
		}
	}
}
