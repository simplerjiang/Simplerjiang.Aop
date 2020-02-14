using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingPassInstanceQueryModel : AopObject
	{
		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("pass_id")]
		public string PassId
		{
			get;
			set;
		}

		[XmlElement("serial_number")]
		public string SerialNumber
		{
			get;
			set;
		}

		[XmlElement("tpl_id")]
		public string TplId
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
