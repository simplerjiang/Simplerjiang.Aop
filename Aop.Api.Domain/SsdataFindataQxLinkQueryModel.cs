using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataFindataQxLinkQueryModel : AopObject
	{
		[XmlElement("ext_param")]
		public string ExtParam
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

		[XmlElement("redirect_url")]
		public string RedirectUrl
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
