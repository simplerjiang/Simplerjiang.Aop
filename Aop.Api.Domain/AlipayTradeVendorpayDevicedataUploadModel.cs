using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeVendorpayDevicedataUploadModel : AopObject
	{
		[XmlElement("app_package_name")]
		public string AppPackageName
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("imei")]
		public string Imei
		{
			get;
			set;
		}

		[XmlElement("imsi")]
		public string Imsi
		{
			get;
			set;
		}

		[XmlElement("mac")]
		public string Mac
		{
			get;
			set;
		}

		[XmlElement("machine_type")]
		public string MachineType
		{
			get;
			set;
		}

		[XmlElement("phone_sys_version")]
		public string PhoneSysVersion
		{
			get;
			set;
		}

		[XmlElement("public_key")]
		public string PublicKey
		{
			get;
			set;
		}

		[XmlElement("tidsource")]
		public string Tidsource
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

		[XmlElement("vendor")]
		public string Vendor
		{
			get;
			set;
		}
	}
}
