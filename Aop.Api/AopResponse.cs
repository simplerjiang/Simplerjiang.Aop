using System;
using System.Xml.Serialization;

namespace Aop.Api
{
	[Serializable]
	public abstract class AopResponse
	{
		private string code;

		private string msg;

		private string subCode;

		private string subMsg;

		private string body;

		[XmlElement("code")]
		public string Code
		{
			get
			{
				return code;
			}
			set
			{
				code = value;
			}
		}

		[XmlElement("msg")]
		public string Msg
		{
			get
			{
				return msg;
			}
			set
			{
				msg = value;
			}
		}

		[XmlElement("sub_code")]
		public string SubCode
		{
			get
			{
				return subCode;
			}
			set
			{
				subCode = value;
			}
		}

		[XmlElement("sub_msg")]
		public string SubMsg
		{
			get
			{
				return subMsg;
			}
			set
			{
				subMsg = value;
			}
		}

		public string Body
		{
			get
			{
				return body;
			}
			set
			{
				body = value;
			}
		}

		public bool IsError => !string.IsNullOrEmpty(SubCode);
	}
}
