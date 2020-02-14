using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketShopCreateResponse : AopResponse
	{
		[XmlElement("apply_id")]
		public string ApplyId
		{
			get;
			set;
		}

		[XmlElement("audit_desc")]
		public string AuditDesc
		{
			get;
			set;
		}

		[XmlElement("audit_status")]
		public string AuditStatus
		{
			get;
			set;
		}

		[XmlElement("is_online")]
		public string IsOnline
		{
			get;
			set;
		}

		[XmlElement("is_show")]
		public string IsShow
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}
