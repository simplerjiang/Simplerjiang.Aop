using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAddressQueryResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("address_code")]
		public string AddressCode
		{
			get;
			set;
		}

		[XmlElement("area")]
		public string Area
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

		[XmlElement("coordinate")]
		public string Coordinate
		{
			get;
			set;
		}

		[XmlElement("default_user_address")]
		public string DefaultUserAddress
		{
			get;
			set;
		}

		[XmlElement("fullname")]
		public string Fullname
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

		[XmlElement("prov")]
		public string Prov
		{
			get;
			set;
		}
	}
}
