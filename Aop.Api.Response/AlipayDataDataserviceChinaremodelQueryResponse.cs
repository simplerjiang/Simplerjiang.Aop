using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceChinaremodelQueryResponse : AopResponse
	{
		[XmlElement("result")]
		public AlipayChinareModelResult Result
		{
			get;
			set;
		}
	}
}
