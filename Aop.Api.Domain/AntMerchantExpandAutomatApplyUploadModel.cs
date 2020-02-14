using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandAutomatApplyUploadModel : AopObject
	{
		[XmlElement("associate")]
		public SmartAutomatAssociate Associate
		{
			get;
			set;
		}

		[XmlElement("delivery_address")]
		public SmartAddressInfo DeliveryAddress
		{
			get;
			set;
		}

		[XmlElement("machine_cooperation_type")]
		public string MachineCooperationType
		{
			get;
			set;
		}

		[XmlElement("machine_delivery_date")]
		public string MachineDeliveryDate
		{
			get;
			set;
		}

		[XmlElement("machine_name")]
		public string MachineName
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

		[XmlElement("merchant_user_id")]
		public string MerchantUserId
		{
			get;
			set;
		}

		[XmlElement("merchant_user_type")]
		public string MerchantUserType
		{
			get;
			set;
		}

		[XmlElement("point_position")]
		public SmartAddressInfo PointPosition
		{
			get;
			set;
		}

		[XmlElement("product_user_id")]
		public string ProductUserId
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public SmartAutomatScene Scene
		{
			get;
			set;
		}

		[XmlElement("terminal_id")]
		public string TerminalId
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
