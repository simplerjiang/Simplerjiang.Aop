using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenOperatorSyncModel : AopObject
	{
		[XmlElement("master_user_id")]
		public string MasterUserId
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}
	}
}
