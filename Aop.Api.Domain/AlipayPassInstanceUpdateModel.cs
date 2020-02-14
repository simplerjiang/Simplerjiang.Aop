using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayPassInstanceUpdateModel : AopObject
	{
		[XmlElement("channel_id")]
		public string ChannelId
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("tpl_params")]
		public string TplParams
		{
			get;
			set;
		}

		[XmlElement("verify_code")]
		public string VerifyCode
		{
			get;
			set;
		}

		[XmlElement("verify_type")]
		public string VerifyType
		{
			get;
			set;
		}
	}
}
