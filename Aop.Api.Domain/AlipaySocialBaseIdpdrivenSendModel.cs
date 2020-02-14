using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseIdpdrivenSendModel : AopObject
	{
		[XmlElement("asset_id")]
		public string AssetId
		{
			get;
			set;
		}

		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("data_time")]
		public long DataTime
		{
			get;
			set;
		}
	}
}
