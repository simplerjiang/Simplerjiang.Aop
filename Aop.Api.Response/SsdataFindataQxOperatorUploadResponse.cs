using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataFindataQxOperatorUploadResponse : AopResponse
	{
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
