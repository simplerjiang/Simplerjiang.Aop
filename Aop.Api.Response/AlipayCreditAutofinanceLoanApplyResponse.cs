using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCreditAutofinanceLoanApplyResponse : AopResponse
	{
		[XmlElement("applyno")]
		public string Applyno
		{
			get;
			set;
		}

		[XmlElement("needauth")]
		public bool Needauth
		{
			get;
			set;
		}

		[XmlElement("outorderno")]
		public string Outorderno
		{
			get;
			set;
		}
	}
}
