using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditCreditriskGuarschemeQueryModel : AopObject
	{
		[XmlElement("bsn_type")]
		public string BsnType
		{
			get;
			set;
		}

		[XmlElement("sale_pd_code")]
		public string SalePdCode
		{
			get;
			set;
		}

		[XmlElement("user")]
		public Member User
		{
			get;
			set;
		}
	}
}
