using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceFileSyncRetryModel : AopObject
	{
		[XmlElement("einv_code")]
		public string EinvCode
		{
			get;
			set;
		}

		[XmlElement("einv_no")]
		public string EinvNo
		{
			get;
			set;
		}

		[XmlElement("file_url")]
		public string FileUrl
		{
			get;
			set;
		}

		[XmlElement("is_url_replace")]
		public bool IsUrlReplace
		{
			get;
			set;
		}

		[XmlElement("m_short_name")]
		public string MShortName
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
