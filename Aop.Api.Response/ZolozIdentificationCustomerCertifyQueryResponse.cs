using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozIdentificationCustomerCertifyQueryResponse : AopResponse
	{
		[XmlElement("attack")]
		public bool Attack
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("img_str")]
		public string ImgStr
		{
			get;
			set;
		}

		[XmlElement("result")]
		public bool Result
		{
			get;
			set;
		}
	}
}
