using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMemberBrandownerNameQueryResponse : AopResponse
	{
		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
