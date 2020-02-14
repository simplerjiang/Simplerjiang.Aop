using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCmsCdataUploadResponse : AopResponse
	{
		[XmlElement("id")]
		public long Id
		{
			get;
			set;
		}
	}
}
