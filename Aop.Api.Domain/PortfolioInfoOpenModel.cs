using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PortfolioInfoOpenModel : AopObject
	{
		[XmlElement("cover_image_id")]
		public string CoverImageId
		{
			get;
			set;
		}

		[XmlElement("cover_image_type")]
		public string CoverImageType
		{
			get;
			set;
		}

		[XmlElement("cover_image_url")]
		public string CoverImageUrl
		{
			get;
			set;
		}

		[XmlElement("portfolio_id")]
		public string PortfolioId
		{
			get;
			set;
		}

		[XmlElement("portfolio_title")]
		public string PortfolioTitle
		{
			get;
			set;
		}
	}
}
