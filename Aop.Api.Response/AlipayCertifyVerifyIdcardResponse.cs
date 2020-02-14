using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCertifyVerifyIdcardResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}
	}
}
