using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicFollowBatchqueryModel : AopObject
	{
		[XmlElement("next_user_id")]
		public string NextUserId
		{
			get;
			set;
		}
	}
}
