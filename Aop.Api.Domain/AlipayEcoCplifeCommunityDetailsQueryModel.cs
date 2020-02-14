using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoCplifeCommunityDetailsQueryModel : AopObject
	{
		[XmlElement("community_id")]
		public string CommunityId
		{
			get;
			set;
		}
	}
}
