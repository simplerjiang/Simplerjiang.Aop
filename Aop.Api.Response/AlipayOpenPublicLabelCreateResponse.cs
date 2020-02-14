using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLabelCreateResponse : AopResponse
	{
		[XmlElement("id")]
		public long Id
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
