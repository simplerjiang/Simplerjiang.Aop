using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsMarketingCertificateBatchqueryModel : AopObject
	{
		[XmlElement("certificate_no")]
		public string CertificateNo
		{
			get;
			set;
		}

		[XmlElement("certificate_type")]
		public string CertificateType
		{
			get;
			set;
		}

		[XmlElement("current_page_no")]
		public long CurrentPageNo
		{
			get;
			set;
		}

		[XmlElement("effect_time")]
		public string EffectTime
		{
			get;
			set;
		}

		[XmlElement("inst_id")]
		public string InstId
		{
			get;
			set;
		}

		[XmlElement("is_enabled")]
		public string IsEnabled
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("order_source")]
		public string OrderSource
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

		[XmlElement("owner_uid")]
		public string OwnerUid
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

		[XmlElement("status")]
		public long Status
		{
			get;
			set;
		}
	}
}
