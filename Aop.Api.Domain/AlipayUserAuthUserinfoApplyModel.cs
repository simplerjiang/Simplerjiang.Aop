using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAuthUserinfoApplyModel : AopObject
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("ext_data")]
		public string ExtData
		{
			get;
			set;
		}
	}
}
