using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryResponse : AopResponse
	{
		[XmlElement("yufaa")]
		public string Yufaa
		{
			get;
			set;
		}
	}
}
