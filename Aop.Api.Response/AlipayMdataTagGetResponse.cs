using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMdataTagGetResponse : AopResponse
	{
		[XmlElement("tag_values")]
		public string TagValues
		{
			get;
			set;
		}
	}
}
