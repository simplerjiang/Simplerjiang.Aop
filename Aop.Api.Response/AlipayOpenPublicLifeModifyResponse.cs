using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeModifyResponse : AopResponse
	{
		[XmlElement("modify_time")]
		public string ModifyTime
		{
			get;
			set;
		}

		[XmlElement("public_id")]
		public string PublicId
		{
			get;
			set;
		}
	}
}
