using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipaySecurityInfoAnalysisRequest : IAopRequest<AlipaySecurityInfoAnalysisResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

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

		public string JsTokenId
		{
			get;
			set;
		}

		public string PartnerId
		{
			get;
			set;
		}

		public string SceneCode
		{
			get;
			set;
		}

		public string UserAccountNo
		{
			get;
			set;
		}

		public string UserBindBankcard
		{
			get;
			set;
		}

		public string UserBindBankcardType
		{
			get;
			set;
		}

		public string UserBindMobile
		{
			get;
			set;
		}

		public string UserIdentityType
		{
			get;
			set;
		}

		public string UserRealName
		{
			get;
			set;
		}

		public string UserRegDate
		{
			get;
			set;
		}

		public string UserRegEmail
		{
			get;
			set;
		}

		public string UserRegMobile
		{
			get;
			set;
		}

		public string UserrIdentityNo
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
			return "alipay.security.info.analysis";
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
			aopDictionary.Add("js_token_id", JsTokenId);
			aopDictionary.Add("partner_id", PartnerId);
			aopDictionary.Add("scene_code", SceneCode);
			aopDictionary.Add("user_account_no", UserAccountNo);
			aopDictionary.Add("user_bind_bankcard", UserBindBankcard);
			aopDictionary.Add("user_bind_bankcard_type", UserBindBankcardType);
			aopDictionary.Add("user_bind_mobile", UserBindMobile);
			aopDictionary.Add("user_identity_type", UserIdentityType);
			aopDictionary.Add("user_real_name", UserRealName);
			aopDictionary.Add("user_reg_date", UserRegDate);
			aopDictionary.Add("user_reg_email", UserRegEmail);
			aopDictionary.Add("user_reg_mobile", UserRegMobile);
			aopDictionary.Add("userr_identity_no", UserrIdentityNo);
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
