using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BeaconDeviceInfo : AopObject
	{
		[XmlElement("actiontype")]
		public string Actiontype
		{
			get;
			set;
		}

		[XmlElement("inuse")]
		public bool Inuse
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("sn")]
		public string Sn
		{
			get;
			set;
		}

		[XmlElement("template")]
		public BeaconTemplate Template
		{
			get;
			set;
		}

		[XmlElement("uuid")]
		public string Uuid
		{
			get;
			set;
		}
	}
}
