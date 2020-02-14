using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceCodeRecoResponse : AopResponse
	{
		[XmlElement("result")]
		public AlipayCodeRecoResult Result
		{
			get;
			set;
		}
	}
}
