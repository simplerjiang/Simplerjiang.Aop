using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ChargeItems : AopObject
	{
		[XmlElement("item_mandatory")]
		public string ItemMandatory
		{
			get;
			set;
		}

		[XmlElement("item_maximum")]
		public long ItemMaximum
		{
			get;
			set;
		}

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("item_price")]
		public string ItemPrice
		{
			get;
			set;
		}

		[XmlElement("item_serial_number")]
		public long ItemSerialNumber
		{
			get;
			set;
		}
	}
}
