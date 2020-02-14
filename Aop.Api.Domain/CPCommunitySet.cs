using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CPCommunitySet : AopObject
	{
		[XmlElement("community_id")]
		public string CommunityId
		{
			get;
			set;
		}

		[XmlElement("merchant_pid")]
		public string MerchantPid
		{
			get;
			set;
		}

		[XmlElement("out_community_id")]
		public string OutCommunityId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
