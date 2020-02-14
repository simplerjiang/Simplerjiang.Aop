using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringKbcodeQueryModel : AopObject
	{
		[XmlElement("batch_id")]
		public long BatchId
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
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

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}
