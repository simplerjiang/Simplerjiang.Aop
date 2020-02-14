using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataFindataQxUserinfoUploadModel : AopObject
	{
		[XmlElement("ext_params")]
		public string ExtParams
		{
			get;
			set;
		}

		[XmlElement("id_card_no")]
		public string IdCardNo
		{
			get;
			set;
		}

		[XmlElement("org_biz_no")]
		public string OrgBizNo
		{
			get;
			set;
		}

		[XmlElement("phone")]
		public string Phone
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
