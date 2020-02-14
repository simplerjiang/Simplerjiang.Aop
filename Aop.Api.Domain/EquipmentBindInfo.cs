using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EquipmentBindInfo : AopObject
	{
		[XmlElement("equipment_id")]
		public string EquipmentId
		{
			get;
			set;
		}

		[XmlElement("is_bind_shop")]
		public string IsBindShop
		{
			get;
			set;
		}
	}
}
