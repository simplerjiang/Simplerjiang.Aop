using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserNewsceneTagQueryResponse : AopResponse
	{
		[XmlElement("tags_result")]
		public string TagsResult
		{
			get;
			set;
		}
	}
}
