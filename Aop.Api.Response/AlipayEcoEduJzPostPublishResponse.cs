using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduJzPostPublishResponse : AopResponse
	{
		[XmlElement("third_id")]
		public string ThirdId
		{
			get;
			set;
		}
	}
}
