using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ShopCommentInfo : AopObject
	{
		[XmlElement("avg_popularity")]
		public string AvgPopularity
		{
			get;
			set;
		}

		[XmlElement("avg_popularity_name")]
		public string AvgPopularityName
		{
			get;
			set;
		}

		[XmlElement("score")]
		public string Score
		{
			get;
			set;
		}

		[XmlElement("star")]
		public string Star
		{
			get;
			set;
		}
	}
}
