using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceDtevalIdentityinfoQueryResponse : AopResponse
	{
		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("id_card_no")]
		public string IdCardNo
		{
			get;
			set;
		}

		[XmlElement("phone")]
		public string Phone
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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
