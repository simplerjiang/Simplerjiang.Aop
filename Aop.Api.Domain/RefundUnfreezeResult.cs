using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RefundUnfreezeResult : AopObject
	{
		[XmlElement("freeze_no")]
		public string FreezeNo
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("unfreeze_amount")]
		public string UnfreezeAmount
		{
			get;
			set;
		}

		[XmlElement("unfreeze_no")]
		public string UnfreezeNo
		{
			get;
			set;
		}

		[XmlElement("unfreeze_time")]
		public string UnfreezeTime
		{
			get;
			set;
		}
	}
}
