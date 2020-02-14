using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProdmodeAgreementUploadResponse : AopResponse
	{
		[XmlElement("is_success")]
		public string IsSuccess
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}
	}
}
