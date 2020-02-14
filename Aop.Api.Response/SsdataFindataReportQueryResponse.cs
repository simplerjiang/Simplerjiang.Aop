using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataFindataReportQueryResponse : AopResponse
	{
		[XmlElement("biz_content")]
		public string BizContent
		{
			get;
			set;
		}

		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("org_biz_no")]
		public string OrgBizNo
		{
			get;
			set;
		}
	}
}
