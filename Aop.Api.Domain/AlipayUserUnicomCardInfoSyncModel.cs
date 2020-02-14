using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserUnicomCardInfoSyncModel : AopObject
	{
		[XmlElement("gmt_status_change")]
		public string GmtStatusChange
		{
			get;
			set;
		}

		[XmlElement("phone_no")]
		public string PhoneNo
		{
			get;
			set;
		}

		[XmlElement("phone_no_status")]
		public string PhoneNoStatus
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
