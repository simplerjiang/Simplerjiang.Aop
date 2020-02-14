using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMsaasPromotionCpainfoCreateModel : AopObject
	{
		[XmlElement("app_id")]
		public string AppId
		{
			get;
			set;
		}

		[XmlElement("app_version")]
		public string AppVersion
		{
			get;
			set;
		}

		[XmlElement("bundle_id")]
		public string BundleId
		{
			get;
			set;
		}

		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlElement("debug")]
		public string Debug
		{
			get;
			set;
		}

		[XmlElement("extend")]
		public string Extend
		{
			get;
			set;
		}

		[XmlElement("idfa")]
		public string Idfa
		{
			get;
			set;
		}

		[XmlElement("ios_version")]
		public string IosVersion
		{
			get;
			set;
		}

		[XmlElement("mac")]
		public string Mac
		{
			get;
			set;
		}
	}
}
