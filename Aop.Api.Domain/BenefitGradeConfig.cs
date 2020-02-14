using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BenefitGradeConfig : AopObject
	{
		[XmlElement("background_url")]
		public string BackgroundUrl
		{
			get;
			set;
		}

		[XmlElement("detail")]
		public string Detail
		{
			get;
			set;
		}

		[XmlElement("grade")]
		public string Grade
		{
			get;
			set;
		}

		[XmlElement("page_url")]
		public string PageUrl
		{
			get;
			set;
		}

		[XmlElement("point")]
		public long Point
		{
			get;
			set;
		}

		[XmlElement("point_discount")]
		public string PointDiscount
		{
			get;
			set;
		}
	}
}
