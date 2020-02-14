using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VcpAssetDetail : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("assetamount")]
		public string Assetamount
		{
			get;
			set;
		}

		[XmlElement("assetusechannel")]
		public string Assetusechannel
		{
			get;
			set;
		}

		[XmlElement("settleuserid")]
		public string Settleuserid
		{
			get;
			set;
		}
	}
}
