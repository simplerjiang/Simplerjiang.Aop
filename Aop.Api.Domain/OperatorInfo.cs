using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OperatorInfo : AopObject
	{
		[XmlElement("operator_cert_indate")]
		public string OperatorCertIndate
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

		[XmlElement("operator_cert_pic_back")]
		public string OperatorCertPicBack
		{
			get;
			set;
		}

		[XmlElement("operator_cert_pic_front")]
		public string OperatorCertPicFront
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

		[XmlElement("operator_name")]
		public string OperatorName
		{
			get;
			set;
		}
	}
}
