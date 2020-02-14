using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLabelUserQueryResponse : AopResponse
	{
		[XmlElement("label_ids")]
		public string LabelIds
		{
			get;
			set;
		}
	}
}
