using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayWeiboPucChargeRequest : IAopRequest<AlipayWeiboPucChargeResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string ApdId
		{
			get;
			set;
		}

		public string CellId
		{
			get;
			set;
		}

		public string DeviceInfoToken
		{
			get;
			set;
		}

		public string Exparam
		{
			get;
			set;
		}

		public string Imei
		{
			get;
			set;
		}

		public string Ip
		{
			get;
			set;
		}

		public string LacId
		{
			get;
			set;
		}

		public string LoginFrom
		{
			get;
			set;
		}

		public string Mac
		{
			get;
			set;
		}

		public string PartnerUserId
		{
			get;
			set;
		}

		public string Tid
		{
			get;
			set;
		}

		public string Token
		{
			get;
			set;
		}

		public string Umid
		{
			get;
			set;
		}

		public string WirelessMac
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
			return "alipay.weibo.puc.charge";
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
			aopDictionary.Add("apd_id", ApdId);
			aopDictionary.Add("cell_id", CellId);
			aopDictionary.Add("device_info_token", DeviceInfoToken);
			aopDictionary.Add("exparam", Exparam);
			aopDictionary.Add("imei", Imei);
			aopDictionary.Add("ip", Ip);
			aopDictionary.Add("lac_id", LacId);
			aopDictionary.Add("login_from", LoginFrom);
			aopDictionary.Add("mac", Mac);
			aopDictionary.Add("partner_user_id", PartnerUserId);
			aopDictionary.Add("tid", Tid);
			aopDictionary.Add("token", Token);
			aopDictionary.Add("umid", Umid);
			aopDictionary.Add("wireless_mac", WirelessMac);
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
