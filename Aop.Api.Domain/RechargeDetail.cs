using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RechargeDetail : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("assetamount")]
		public string Assetamount
		{
			get;
			set;
		}

		[XmlElement("orderno")]
		public string Orderno
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
