using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignActivityOfflineModel : AopObject
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("operator_type")]
		public string OperatorType
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("reason")]
		public string Reason
		{
			get;
			set;
		}
	}
}
