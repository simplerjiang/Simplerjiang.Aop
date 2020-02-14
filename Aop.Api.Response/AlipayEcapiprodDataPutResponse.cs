using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcapiprodDataPutResponse : AopResponse
	{
		[XmlElement("data_version")]
		public string DataVersion
		{
			get;
			set;
		}
	}
}
