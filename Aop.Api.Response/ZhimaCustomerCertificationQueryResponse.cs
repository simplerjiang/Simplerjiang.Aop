using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCustomerCertificationQueryResponse : AopResponse
	{
		[XmlElement("attribute_info")]
		public string AttributeInfo
		{
			get;
			set;
		}

		[XmlElement("channel_statuses")]
		public string ChannelStatuses
		{
			get;
			set;
		}

		[XmlElement("failed_reason")]
		public string FailedReason
		{
			get;
			set;
		}

		[XmlElement("identity_info")]
		public string IdentityInfo
		{
			get;
			set;
		}

		[XmlElement("passed")]
		public string Passed
		{
			get;
			set;
		}
	}
}
