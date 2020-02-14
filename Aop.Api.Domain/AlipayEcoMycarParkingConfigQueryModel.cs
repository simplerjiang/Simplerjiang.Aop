using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingConfigQueryModel : AopObject
	{
		[XmlElement("interface_name")]
		public string InterfaceName
		{
			get;
			set;
		}

		[XmlElement("interface_type")]
		public string InterfaceType
		{
			get;
			set;
		}
	}
}
