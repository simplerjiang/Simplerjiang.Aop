using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VoucherDetail : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
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

		[XmlElement("merchant_contribute")]
		public string MerchantContribute
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

		[XmlElement("other_contribute")]
		public string OtherContribute
		{
			get;
			set;
		}

		[XmlArray("other_contribute_detail")]
		[XmlArrayItem("contribute_detail")]
		public List<ContributeDetail> OtherContributeDetail
		{
			get;
			set;
		}

		[XmlElement("purchase_ant_contribute")]
		public string PurchaseAntContribute
		{
			get;
			set;
		}

		[XmlElement("purchase_buyer_contribute")]
		public string PurchaseBuyerContribute
		{
			get;
			set;
		}

		[XmlElement("purchase_merchant_contribute")]
		public string PurchaseMerchantContribute
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
