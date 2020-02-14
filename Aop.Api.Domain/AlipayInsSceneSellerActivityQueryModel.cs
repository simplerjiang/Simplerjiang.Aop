using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneSellerActivityQueryModel : AopObject
	{
		[XmlElement("channel_account_id")]
		public string ChannelAccountId
		{
			get;
			set;
		}

		[XmlElement("channel_account_type")]
		public long ChannelAccountType
		{
			get;
			set;
		}

		[XmlElement("sp_code")]
		public string SpCode
		{
			get;
			set;
		}
	}
}
