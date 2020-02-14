using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingSharetokenDecodeResponse : AopResponse
	{
		[XmlElement("btn_one_name")]
		public string BtnOneName
		{
			get;
			set;
		}

		[XmlElement("btn_one_schema")]
		public string BtnOneSchema
		{
			get;
			set;
		}

		[XmlElement("btn_two_name")]
		public string BtnTwoName
		{
			get;
			set;
		}

		[XmlElement("btn_two_schema")]
		public string BtnTwoSchema
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("icon")]
		public string Icon
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
