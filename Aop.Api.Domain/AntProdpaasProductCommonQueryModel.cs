using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntProdpaasProductCommonQueryModel : AopObject
	{
		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("product_options")]
		public ProductVOOptions ProductOptions
		{
			get;
			set;
		}

		[XmlElement("product_version")]
		public string ProductVersion
		{
			get;
			set;
		}
	}
}
