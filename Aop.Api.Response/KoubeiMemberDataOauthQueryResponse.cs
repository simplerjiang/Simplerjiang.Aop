using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMemberDataOauthQueryResponse : AopResponse
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("operator_partner_id")]
		public string OperatorPartnerId
		{
			get;
			set;
		}

		[XmlElement("operator_type")]
		public string OperatorType
		{
			get;
			set;
		}
	}
}
