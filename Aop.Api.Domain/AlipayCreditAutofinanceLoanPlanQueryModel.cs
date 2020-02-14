using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCreditAutofinanceLoanPlanQueryModel : AopObject
	{
		[XmlElement("extparam")]
		public string Extparam
		{
			get;
			set;
		}

		[XmlElement("orgcode")]
		public string Orgcode
		{
			get;
			set;
		}

		[XmlElement("productcode")]
		public string Productcode
		{
			get;
			set;
		}

		[XmlElement("seqno")]
		public string Seqno
		{
			get;
			set;
		}

		[XmlElement("uid")]
		public string Uid
		{
			get;
			set;
		}
	}
}
