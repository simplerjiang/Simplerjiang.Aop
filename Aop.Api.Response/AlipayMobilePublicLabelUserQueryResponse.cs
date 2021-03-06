using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicLabelUserQueryResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("label_ids")]
		public string LabelIds
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}
	}
}
