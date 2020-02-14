using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayZdatafrontDatatransferedFileuploadResponse : AopResponse
	{
		[XmlElement("result_data")]
		public string ResultData
		{
			get;
			set;
		}

		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}
	}
}
