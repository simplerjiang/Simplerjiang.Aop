using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeRoominfoQueryModel : AopObject
	{
		[XmlElement("community_id")]
		public string CommunityId
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
	}
}
