using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenOperationPartnerLoginCreateModel : AopObject
	{
		[XmlElement("staff_user_id")]
		public string StaffUserId
		{
			get;
			set;
		}
	}
}
