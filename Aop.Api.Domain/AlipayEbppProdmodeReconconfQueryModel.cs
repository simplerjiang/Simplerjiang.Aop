using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppProdmodeReconconfQueryModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("chargeoff_code")]
		public string ChargeoffCode
		{
			get;
			set;
		}
	}
}
