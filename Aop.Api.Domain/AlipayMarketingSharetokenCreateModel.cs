using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingSharetokenCreateModel : AopObject
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

		[XmlElement("btn_left")]
		public string BtnLeft
		{
			get;
			set;
		}

		[XmlElement("btn_left_href")]
		public string BtnLeftHref
		{
			get;
			set;
		}

		[XmlElement("btn_right")]
		public string BtnRight
		{
			get;
			set;
		}

		[XmlElement("btn_right_href")]
		public string BtnRightHref
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("icon")]
		public string Icon
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

		[XmlElement("timeout")]
		public long Timeout
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
	}
}
