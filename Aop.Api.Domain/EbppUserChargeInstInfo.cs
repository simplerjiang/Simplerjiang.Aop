using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EbppUserChargeInstInfo : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

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

		[XmlElement("sub_biz_type")]
		public string SubBizType
		{
			get;
			set;
		}
	}
}
