using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PrincipalInfo : AopObject
	{
		[XmlElement("mobile_no")]
		public string MobileNo
		{
			get;
			set;
		}

		[XmlElement("operator_cert_no")]
		public string OperatorCertNo
		{
			get;
			set;
		}

		[XmlElement("operator_cert_type")]
		public string OperatorCertType
		{
			get;
			set;
		}

		[XmlElement("params")]
		public string Params
		{
			get;
			set;
		}

		[XmlElement("tnt_inst_id")]
		public string TntInstId
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

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
