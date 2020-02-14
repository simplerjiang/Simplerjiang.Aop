using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishEstimatedInfo : AopObject
	{
		[XmlElement("ds_id")]
		public string DsId
		{
			get;
			set;
		}

		[XmlElement("ds_type")]
		public string DsType
		{
			get;
			set;
		}

		[XmlElement("inventory")]
		public string Inventory
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
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

		[XmlElement("update_user")]
		public string UpdateUser
		{
			get;
			set;
		}
	}
}
