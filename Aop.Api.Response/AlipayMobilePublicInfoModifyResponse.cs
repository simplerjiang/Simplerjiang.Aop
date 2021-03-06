using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicInfoModifyResponse : AopResponse
	{
		[XmlElement("audit_desc")]
		public string AuditDesc
		{
			get;
			set;
		}

		[XmlElement("audit_status")]
		public string AuditStatus
		{
			get;
			set;
		}
	}
}
