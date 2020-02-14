using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProdmodeUnionbankQueryResponse : AopResponse
	{
		[XmlElement("bank_code")]
		public string BankCode
		{
			get;
			set;
		}

		[XmlElement("bank_name")]
		public string BankName
		{
			get;
			set;
		}

		[XmlElement("branch_name")]
		public string BranchName
		{
			get;
			set;
		}

		[XmlElement("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("prov")]
		public string Prov
		{
			get;
			set;
		}
	}
}
