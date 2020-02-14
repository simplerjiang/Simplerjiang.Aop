using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenServicemarketCommodityQueryResponse : AopResponse
	{
		[XmlElement("app_hot_logo")]
		public string AppHotLogo
		{
			get;
			set;
		}

		[XmlElement("audit_memo")]
		public string AuditMemo
		{
			get;
			set;
		}

		[XmlElement("authorization_file")]
		public string AuthorizationFile
		{
			get;
			set;
		}

		[XmlElement("biz_type_code")]
		public string BizTypeCode
		{
			get;
			set;
		}

		[XmlElement("category_code")]
		public string CategoryCode
		{
			get;
			set;
		}

		[XmlElement("category_id")]
		public string CategoryId
		{
			get;
			set;
		}

		[XmlElement("commodity_affiliation")]
		public string CommodityAffiliation
		{
			get;
			set;
		}

		[XmlElement("commodity_id")]
		public string CommodityId
		{
			get;
			set;
		}

		[XmlElement("contactor")]
		public string Contactor
		{
			get;
			set;
		}

		[XmlElement("create_date")]
		public string CreateDate
		{
			get;
			set;
		}

		[XmlElement("log_url")]
		public string LogUrl
		{
			get;
			set;
		}

		[XmlElement("mobile_visiturl")]
		public string MobileVisiturl
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("sub_status")]
		public string SubStatus
		{
			get;
			set;
		}

		[XmlElement("subtitle")]
		public string Subtitle
		{
			get;
			set;
		}

		[XmlElement("test_detail")]
		public string TestDetail
		{
			get;
			set;
		}

		[XmlElement("test_report")]
		public string TestReport
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlElement("user_guide")]
		public string UserGuide
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
