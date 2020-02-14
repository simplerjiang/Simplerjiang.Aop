using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceAntdacEasyserviceQueryResponse : AopResponse
	{
		[XmlElement("ret_val")]
		public string RetVal
		{
			get;
			set;
		}
	}
}
