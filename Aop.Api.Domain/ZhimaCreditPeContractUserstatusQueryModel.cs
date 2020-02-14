using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditPeContractUserstatusQueryModel : AopObject
	{
		[XmlElement("activity_name")]
		public string ActivityName
		{
			get;
			set;
		}

		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("uid")]
		public string Uid
		{
			get;
			set;
		}
	}
}
