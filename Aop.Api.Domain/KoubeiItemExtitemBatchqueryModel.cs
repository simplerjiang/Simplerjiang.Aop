using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiItemExtitemBatchqueryModel : AopObject
	{
		[XmlElement("brand_code")]
		public string BrandCode
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

		[XmlElement("page_num")]
		public string PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
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
