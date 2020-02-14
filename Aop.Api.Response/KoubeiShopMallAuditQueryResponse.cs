using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiShopMallAuditQueryResponse : AopResponse
	{
		[XmlElement("audit_remark")]
		public string AuditRemark
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
