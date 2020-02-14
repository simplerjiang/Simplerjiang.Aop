using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserIdenticalAuthbaseQueryResponse : AopResponse
	{
		[XmlElement("identical")]
		public bool Identical
		{
			get;
			set;
		}
	}
}
