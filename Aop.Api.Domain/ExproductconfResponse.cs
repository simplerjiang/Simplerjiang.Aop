using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExproductconfResponse : AopObject
	{
		[XmlElement("charge_inst")]
		public string ChargeInst
		{
			get;
			set;
		}

		[XmlElement("chargeinst_name")]
		public string ChargeinstName
		{
			get;
			set;
		}

		[XmlElement("chargeoff_inst")]
		public string ChargeoffInst
		{
			get;
			set;
		}

		[XmlElement("chargeoffinst_name")]
		public string ChargeoffinstName
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

		[XmlElement("extend")]
		public string Extend
		{
			get;
			set;
		}

		[XmlElement("province")]
		public string Province
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
