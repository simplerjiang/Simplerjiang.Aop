using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPassTemplateAddResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}
	}
}
