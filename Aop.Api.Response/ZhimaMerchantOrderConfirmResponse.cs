using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantOrderConfirmResponse : AopResponse
	{
		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlElement("credit_amout")]
		public string CreditAmout
		{
			get;
			set;
		}

		[XmlElement("ethnic_group")]
		public string EthnicGroup
		{
			get;
			set;
		}

		[XmlElement("house")]
		public string House
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("open_id")]
		public string OpenId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}

		[XmlElement("zm_face")]
		public string ZmFace
		{
			get;
			set;
		}

		[XmlElement("zm_grade")]
		public string ZmGrade
		{
			get;
			set;
		}

		[XmlElement("zm_risk")]
		public string ZmRisk
		{
			get;
			set;
		}

		[XmlElement("zm_score")]
		public string ZmScore
		{
			get;
			set;
		}
	}
}
