using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RecommendInfo : AopObject
	{
		[XmlElement("jump_url")]
		public string JumpUrl
		{
			get;
			set;
		}

		[XmlElement("recommend_content")]
		public string RecommendContent
		{
			get;
			set;
		}

		[XmlElement("recommend_img")]
		public string RecommendImg
		{
			get;
			set;
		}

		[XmlElement("recommend_type")]
		public string RecommendType
		{
			get;
			set;
		}
	}
}
