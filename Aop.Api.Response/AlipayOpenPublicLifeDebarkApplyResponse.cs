using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeDebarkApplyResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
