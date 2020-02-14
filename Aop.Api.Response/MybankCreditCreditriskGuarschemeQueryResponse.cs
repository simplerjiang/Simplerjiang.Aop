using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditCreditriskGuarschemeQueryResponse : AopResponse
	{
		[XmlElement("admit")]
		public bool Admit
		{
			get;
			set;
		}

		[XmlElement("available_amt")]
		public string AvailableAmt
		{
			get;
			set;
		}
	}
}
