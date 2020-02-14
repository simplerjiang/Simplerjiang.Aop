using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsScenePolicySurrenderApplyModel : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("policy_no")]
		public string PolicyNo
		{
			get;
			set;
		}
	}
}
