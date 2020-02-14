using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ChargeInstMode : AopObject
	{
		[XmlElement("charge_inst")]
		public string ChargeInst
		{
			get;
			set;
		}

		[XmlElement("charge_inst_name")]
		public string ChargeInstName
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

		[XmlElement("province")]
		public string Province
		{
			get;
			set;
		}
	}
}
