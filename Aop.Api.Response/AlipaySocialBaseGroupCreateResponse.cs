using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseGroupCreateResponse : AopResponse
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}
	}
}
