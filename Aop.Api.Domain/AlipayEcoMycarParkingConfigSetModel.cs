using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarParkingConfigSetModel : AopObject
	{
		[XmlElement("account_no")]
		public string AccountNo
		{
			get;
			set;
		}

		[XmlArray("interface_info_list")]
		[XmlArrayItem("interface_info_list")]
		public List<InterfaceInfoList> InterfaceInfoList
		{
			get;
			set;
		}

		[XmlElement("merchant_logo")]
		public string MerchantLogo
		{
			get;
			set;
		}

		[XmlElement("merchant_name")]
		public string MerchantName
		{
			get;
			set;
		}

		[XmlElement("merchant_service_phone")]
		public string MerchantServicePhone
		{
			get;
			set;
		}
	}
}
