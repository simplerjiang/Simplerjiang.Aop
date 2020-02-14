using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileCodeQueryResponse : AopResponse
	{
		[XmlElement("biz_linked_id")]
		public string BizLinkedId
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

		[XmlElement("code_status")]
		public string CodeStatus
		{
			get;
			set;
		}

		[XmlElement("context_str")]
		public string ContextStr
		{
			get;
			set;
		}

		[XmlElement("dynamic_img_url")]
		public string DynamicImgUrl
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("is_direct")]
		public string IsDirect
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("qr_code")]
		public string QrCode
		{
			get;
			set;
		}

		[XmlElement("qr_token")]
		public string QrToken
		{
			get;
			set;
		}

		[XmlElement("source_id")]
		public string SourceId
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
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
