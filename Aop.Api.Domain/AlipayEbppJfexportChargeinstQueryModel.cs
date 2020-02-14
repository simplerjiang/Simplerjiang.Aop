using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppJfexportChargeinstQueryModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("page")]
		public long Page
		{
			get;
			set;
		}

		[XmlElement("page_query")]
		public bool PageQuery
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("sub_biz_type")]
		public string SubBizType
		{
			get;
			set;
		}
	}
}
