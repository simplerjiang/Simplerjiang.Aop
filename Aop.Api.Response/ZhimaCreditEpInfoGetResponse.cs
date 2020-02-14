using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpInfoGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("company_info")]
		public CompanyInfo CompanyInfo
		{
			get;
			set;
		}
	}
}
