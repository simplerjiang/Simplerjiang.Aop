using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditScoreBriefGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("is_admittance")]
		public string IsAdmittance
		{
			get;
			set;
		}
	}
}
