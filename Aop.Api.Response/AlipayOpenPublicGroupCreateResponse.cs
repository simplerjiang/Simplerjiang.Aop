using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicGroupCreateResponse : AopResponse
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}
	}
}
