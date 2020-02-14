using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicGisGetResponse : AopResponse
	{
		[XmlElement("accuracy")]
		public string Accuracy
		{
			get;
			set;
		}

		[XmlElement("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}

		[XmlElement("province")]
		public string Province
		{
			get;
			set;
		}
	}
}
