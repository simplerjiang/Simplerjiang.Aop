using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceIotMdeviceprodAssetapplyQueryResponse : AopResponse
	{
		[XmlElement("apply_isv_name")]
		public string ApplyIsvName
		{
			get;
			set;
		}

		[XmlElement("apply_isv_pid")]
		public string ApplyIsvPid
		{
			get;
			set;
		}

		[XmlElement("apply_merchant_mobile")]
		public string ApplyMerchantMobile
		{
			get;
			set;
		}

		[XmlElement("apply_merchant_name")]
		public string ApplyMerchantName
		{
			get;
			set;
		}

		[XmlElement("apply_merchant_pid")]
		public string ApplyMerchantPid
		{
			get;
			set;
		}

		[XmlElement("apply_person_mobile")]
		public string ApplyPersonMobile
		{
			get;
			set;
		}

		[XmlElement("apply_person_name")]
		public string ApplyPersonName
		{
			get;
			set;
		}
	}
}
