using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicAccountlistGetResponse : AopResponse
	{
		[XmlElement("account_list")]
		public string AccountList
		{
			get;
			set;
		}

		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}
	}
}
