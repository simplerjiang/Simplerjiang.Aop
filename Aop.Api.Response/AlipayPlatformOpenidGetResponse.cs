using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPlatformOpenidGetResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("dict")]
		public string Dict
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
