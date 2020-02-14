using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LoanChargeInfo : AopObject
	{
		[XmlElement("charge_code")]
		public string ChargeCode
		{
			get;
			set;
		}

		[XmlElement("charge_name")]
		public string ChargeName
		{
			get;
			set;
		}

		[XmlElement("instal_chrg_rate")]
		public InstallmentValue InstalChrgRate
		{
			get;
			set;
		}
	}
}
