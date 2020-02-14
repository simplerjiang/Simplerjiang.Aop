using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCreditCreditriskDataPutResponse : AopResponse
	{
		[XmlElement("dataid")]
		public string Dataid
		{
			get;
			set;
		}
	}
}
