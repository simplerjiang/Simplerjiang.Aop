using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeLabelCreateResponse : AopResponse
	{
		[XmlElement("label_id")]
		public string LabelId
		{
			get;
			set;
		}
	}
}
