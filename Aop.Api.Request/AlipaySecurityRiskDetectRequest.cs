using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipaySecurityRiskDetectRequest : IAopRequest<AlipaySecurityRiskDetectResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string BuyerAccountNo
		{
			get;
			set;
		}

		public string BuyerBindBankcard
		{
			get;
			set;
		}

		public string BuyerBindBankcardType
		{
			get;
			set;
		}

		public string BuyerBindMobile
		{
			get;
			set;
		}

		public string BuyerGrade
		{
			get;
			set;
		}

		public string BuyerIdentityNo
		{
			get;
			set;
		}

		public string BuyerIdentityType
		{
			get;
			set;
		}

		public string BuyerRealName
		{
			get;
			set;
		}

		public string BuyerRegDate
		{
			get;
			set;
		}

		public string BuyerRegEmail
		{
			get;
			set;
		}

		public string BuyerRegMobile
		{
			get;
			set;
		}

		public string BuyerSceneBankcard
		{
			get;
			set;
		}

		public string BuyerSceneBankcardType
		{
			get;
			set;
		}

		public string BuyerSceneEmail
		{
			get;
			set;
		}

		public string BuyerSceneMobile
		{
			get;
			set;
		}

		public string Currency
		{
			get;
			set;
		}

		public string EnvClientBaseBand
		{
			get;
			set;
		}

		public string EnvClientBaseStation
		{
			get;
			set;
		}

		public string EnvClientCoordinates
		{
			get;
			set;
		}

		public string EnvClientImei
		{
			get;
			set;
		}

		public string EnvClientImsi
		{
			get;
			set;
		}

		public string EnvClientIosUdid
		{
			get;
			set;
		}

		public string EnvClientIp
		{
			get;
			set;
		}

		public string EnvClientMac
		{
			get;
			set;
		}

		public string EnvClientScreen
		{
			get;
			set;
		}

		public string EnvClientUuid
		{
			get;
			set;
		}

		public string ItemQuantity
		{
			get;
			set;
		}

		public string ItemUnitPrice
		{
			get;
			set;
		}

		public string JsTokenId
		{
			get;
			set;
		}

		public string OrderAmount
		{
			get;
			set;
		}

		public string OrderCategory
		{
			get;
			set;
		}

		public string OrderCredateTime
		{
			get;
			set;
		}

		public string OrderItemCity
		{
			get;
			set;
		}

		public string OrderItemName
		{
			get;
			set;
		}

		public string OrderNo
		{
			get;
			set;
		}

		public string PartnerId
		{
			get;
			set;
		}

		public string ReceiverAddress
		{
			get;
			set;
		}

		public string ReceiverCity
		{
			get;
			set;
		}

		public string ReceiverDistrict
		{
			get;
			set;
		}

		public string ReceiverEmail
		{
			get;
			set;
		}

		public string ReceiverMobile
		{
			get;
			set;
		}

		public string ReceiverName
		{
			get;
			set;
		}

		public string ReceiverState
		{
			get;
			set;
		}

		public string ReceiverZip
		{
			get;
			set;
		}

		public string SceneCode
		{
			get;
			set;
		}

		public string SellerAccountNo
		{
			get;
			set;
		}

		public string SellerBindBankcard
		{
			get;
			set;
		}

		public string SellerBindBankcardType
		{
			get;
			set;
		}

		public string SellerBindMobile
		{
			get;
			set;
		}

		public string SellerIdentityNo
		{
			get;
			set;
		}

		public string SellerIdentityType
		{
			get;
			set;
		}

		public string SellerRealName
		{
			get;
			set;
		}

		public string SellerRegDate
		{
			get;
			set;
		}

		public string SellerRegEmail
		{
			get;
			set;
		}

		public string SellerRegMoile
		{
			get;
			set;
		}

		public string TransportType
		{
			get;
			set;
		}

		public void SetNeedEncrypt(bool needEncrypt)
		{
			this.needEncrypt = needEncrypt;
		}

		public bool GetNeedEncrypt()
		{
			return needEncrypt;
		}

		public void SetNotifyUrl(string notifyUrl)
		{
			this.notifyUrl = notifyUrl;
		}

		public string GetNotifyUrl()
		{
			return notifyUrl;
		}

		public void SetReturnUrl(string returnUrl)
		{
			this.returnUrl = returnUrl;
		}

		public string GetReturnUrl()
		{
			return returnUrl;
		}

		public void SetTerminalType(string terminalType)
		{
			this.terminalType = terminalType;
		}

		public string GetTerminalType()
		{
			return terminalType;
		}

		public void SetTerminalInfo(string terminalInfo)
		{
			this.terminalInfo = terminalInfo;
		}

		public string GetTerminalInfo()
		{
			return terminalInfo;
		}

		public void SetProdCode(string prodCode)
		{
			this.prodCode = prodCode;
		}

		public string GetProdCode()
		{
			return prodCode;
		}

		public string GetApiName()
		{
			return "alipay.security.risk.detect";
		}

		public void SetApiVersion(string apiVersion)
		{
			this.apiVersion = apiVersion;
		}

		public string GetApiVersion()
		{
			return apiVersion;
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("buyer_account_no", BuyerAccountNo);
			aopDictionary.Add("buyer_bind_bankcard", BuyerBindBankcard);
			aopDictionary.Add("buyer_bind_bankcard_type", BuyerBindBankcardType);
			aopDictionary.Add("buyer_bind_mobile", BuyerBindMobile);
			aopDictionary.Add("buyer_grade", BuyerGrade);
			aopDictionary.Add("buyer_identity_no", BuyerIdentityNo);
			aopDictionary.Add("buyer_identity_type", BuyerIdentityType);
			aopDictionary.Add("buyer_real_name", BuyerRealName);
			aopDictionary.Add("buyer_reg_date", BuyerRegDate);
			aopDictionary.Add("buyer_reg_email", BuyerRegEmail);
			aopDictionary.Add("buyer_reg_mobile", BuyerRegMobile);
			aopDictionary.Add("buyer_scene_bankcard", BuyerSceneBankcard);
			aopDictionary.Add("buyer_scene_bankcard_type", BuyerSceneBankcardType);
			aopDictionary.Add("buyer_scene_email", BuyerSceneEmail);
			aopDictionary.Add("buyer_scene_mobile", BuyerSceneMobile);
			aopDictionary.Add("currency", Currency);
			aopDictionary.Add("env_client_base_band", EnvClientBaseBand);
			aopDictionary.Add("env_client_base_station", EnvClientBaseStation);
			aopDictionary.Add("env_client_coordinates", EnvClientCoordinates);
			aopDictionary.Add("env_client_imei", EnvClientImei);
			aopDictionary.Add("env_client_imsi", EnvClientImsi);
			aopDictionary.Add("env_client_ios_udid", EnvClientIosUdid);
			aopDictionary.Add("env_client_ip", EnvClientIp);
			aopDictionary.Add("env_client_mac", EnvClientMac);
			aopDictionary.Add("env_client_screen", EnvClientScreen);
			aopDictionary.Add("env_client_uuid", EnvClientUuid);
			aopDictionary.Add("item_quantity", ItemQuantity);
			aopDictionary.Add("item_unit_price", ItemUnitPrice);
			aopDictionary.Add("js_token_id", JsTokenId);
			aopDictionary.Add("order_amount", OrderAmount);
			aopDictionary.Add("order_category", OrderCategory);
			aopDictionary.Add("order_credate_time", OrderCredateTime);
			aopDictionary.Add("order_item_city", OrderItemCity);
			aopDictionary.Add("order_item_name", OrderItemName);
			aopDictionary.Add("order_no", OrderNo);
			aopDictionary.Add("partner_id", PartnerId);
			aopDictionary.Add("receiver_address", ReceiverAddress);
			aopDictionary.Add("receiver_city", ReceiverCity);
			aopDictionary.Add("receiver_district", ReceiverDistrict);
			aopDictionary.Add("receiver_email", ReceiverEmail);
			aopDictionary.Add("receiver_mobile", ReceiverMobile);
			aopDictionary.Add("receiver_name", ReceiverName);
			aopDictionary.Add("receiver_state", ReceiverState);
			aopDictionary.Add("receiver_zip", ReceiverZip);
			aopDictionary.Add("scene_code", SceneCode);
			aopDictionary.Add("seller_account_no", SellerAccountNo);
			aopDictionary.Add("seller_bind_bankcard", SellerBindBankcard);
			aopDictionary.Add("seller_bind_bankcard_type", SellerBindBankcardType);
			aopDictionary.Add("seller_bind_mobile", SellerBindMobile);
			aopDictionary.Add("seller_identity_no", SellerIdentityNo);
			aopDictionary.Add("seller_identity_type", SellerIdentityType);
			aopDictionary.Add("seller_real_name", SellerRealName);
			aopDictionary.Add("seller_reg_date", SellerRegDate);
			aopDictionary.Add("seller_reg_email", SellerRegEmail);
			aopDictionary.Add("seller_reg_moile", SellerRegMoile);
			aopDictionary.Add("transport_type", TransportType);
			return aopDictionary;
		}

		public AopObject GetBizModel()
		{
			return bizModel;
		}

		public void SetBizModel(AopObject bizModel)
		{
			this.bizModel = bizModel;
		}
	}
}
