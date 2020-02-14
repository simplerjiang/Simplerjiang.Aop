using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DeliveryPackageDetail : AopObject
	{
		[XmlElement("express_code")]
		public string ExpressCode
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("goods_code")]
		public string GoodsCode
		{
			get;
			set;
		}

		[XmlElement("goods_quantity")]
		public string GoodsQuantity
		{
			get;
			set;
		}

		[XmlElement("package_code")]
		public string PackageCode
		{
			get;
			set;
		}
	}
}
