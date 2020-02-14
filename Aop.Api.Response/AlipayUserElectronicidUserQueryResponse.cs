using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserElectronicidUserQueryResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("birthday")]
		public string Birthday
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("gender")]
		public string Gender
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

		[XmlElement("nation")]
		public string Nation
		{
			get;
			set;
		}

		[XmlElement("picture")]
		public string Picture
		{
			get;
			set;
		}

		[XmlElement("secret_key")]
		public string SecretKey
		{
			get;
			set;
		}

		[XmlElement("sign_org")]
		public string SignOrg
		{
			get;
			set;
		}

		[XmlElement("valid_begin_date")]
		public string ValidBeginDate
		{
			get;
			set;
		}

		[XmlElement("valid_end_date")]
		public string ValidEndDate
		{
			get;
			set;
		}
	}
}
