using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAntpaasTokenidentityCreateModel : AopObject
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("biz_scene")]
		public string BizScene
		{
			get;
			set;
		}

		[XmlElement("ext_info_id")]
		public string ExtInfoId
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("user_type")]
		public string UserType
		{
			get;
			set;
		}
	}
}
