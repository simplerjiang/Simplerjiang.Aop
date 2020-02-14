using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAntpaasTokenCreateResponse : AopResponse
	{
		[XmlElement("ant_id")]
		public string AntId
		{
			get;
			set;
		}
	}
}
