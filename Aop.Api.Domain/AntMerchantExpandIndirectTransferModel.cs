using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandIndirectTransferModel : AopObject
	{
		[XmlElement("external_id")]
		public string ExternalId
		{
			get;
			set;
		}

		[XmlElement("sub_merchant_id")]
		public string SubMerchantId
		{
			get;
			set;
		}

		[XmlElement("transfer_target_id")]
		public string TransferTargetId
		{
			get;
			set;
		}
	}
}
