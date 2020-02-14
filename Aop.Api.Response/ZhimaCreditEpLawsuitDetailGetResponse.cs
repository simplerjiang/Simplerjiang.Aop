using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpLawsuitDetailGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("lawsuit_detail")]
		public EpInfo LawsuitDetail
		{
			get;
			set;
		}
	}
}
