using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserCharityForestQueryResponse : AopResponse
	{
		[XmlElement("forest_user")]
		public bool ForestUser
		{
			get;
			set;
		}
	}
}
