using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppDeveloperCheckdevelopervalidQueryResponse : AopResponse
	{
		[XmlElement("dev_valid")]
		public bool DevValid
		{
			get;
			set;
		}
	}
}
