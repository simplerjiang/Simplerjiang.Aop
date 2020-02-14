using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppXwbtstabcQueryResponse : AopResponse
	{
		[XmlElement("xwbbbdd")]
		public string Xwbbbdd
		{
			get;
			set;
		}
	}
}
