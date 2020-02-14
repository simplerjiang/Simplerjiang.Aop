using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAccountDeviceInfoUploadResponse : AopResponse
	{
		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}
	}
}
