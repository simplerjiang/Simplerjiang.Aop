using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingAdvertisingOperateModel : AopObject
	{
		[XmlElement("ad_id")]
		public string AdId
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}
	}
}
