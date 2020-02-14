using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneSellerActivityUnsignModel : AopObject
	{
		[XmlElement("channel_account_id")]
		public string ChannelAccountId
		{
			get;
			set;
		}

		[XmlElement("channel_account_type")]
		public string ChannelAccountType
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
