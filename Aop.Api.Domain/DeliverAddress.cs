using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DeliverAddress : AopObject
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

		[XmlElement("default_deliver_address")]
		public string DefaultDeliverAddress
		{
			get;
			set;
		}

		[XmlElement("deliver_area")]
		public string DeliverArea
		{
			get;
			set;
		}

		[XmlElement("deliver_city")]
		public string DeliverCity
		{
			get;
			set;
		}

		[XmlElement("deliver_fullname")]
		public string DeliverFullname
		{
			get;
			set;
		}

		[XmlElement("deliver_mobile")]
		public string DeliverMobile
		{
			get;
			set;
		}

		[XmlElement("deliver_phone")]
		public string DeliverPhone
		{
			get;
			set;
		}

		[XmlElement("deliver_province")]
		public string DeliverProvince
		{
			get;
			set;
		}

		[XmlElement("zip")]
		public string Zip
		{
			get;
			set;
		}
	}
}
