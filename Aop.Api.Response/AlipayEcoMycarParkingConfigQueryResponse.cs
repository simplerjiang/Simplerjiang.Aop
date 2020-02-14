using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarParkingConfigQueryResponse : AopResponse
	{
		[XmlElement("account_no")]
		public string AccountNo
		{
			get;
			set;
		}

		[XmlElement("interface_info_list")]
		public InterfaceInfoList InterfaceInfoList
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
