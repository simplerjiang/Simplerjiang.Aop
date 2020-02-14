using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserTestResponse : AopResponse
	{
		[XmlElement("ret1")]
		public string Ret1
		{
			get;
			set;
		}
	}
}
