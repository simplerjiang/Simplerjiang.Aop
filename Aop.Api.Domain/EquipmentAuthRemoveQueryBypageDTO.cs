using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EquipmentAuthRemoveQueryBypageDTO : AopObject
	{
		[XmlElement("device_id")]
		public string DeviceId
		{
			get;
			set;
		}

		[XmlElement("unbind_time")]
		public string UnbindTime
		{
			get;
			set;
		}
	}
}
