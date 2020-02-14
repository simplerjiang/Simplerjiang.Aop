using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeAboardApplyResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
