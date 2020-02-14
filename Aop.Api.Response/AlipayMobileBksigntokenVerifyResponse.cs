using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileBksigntokenVerifyResponse : AopResponse
	{
		[XmlElement("createtimestamp")]
		public string Createtimestamp
		{
			get;
			set;
		}

		[XmlElement("loginid")]
		public string Loginid
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("resultcode")]
		public long Resultcode
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}

		[XmlElement("userid")]
		public string Userid
		{
			get;
			set;
		}
	}
}
