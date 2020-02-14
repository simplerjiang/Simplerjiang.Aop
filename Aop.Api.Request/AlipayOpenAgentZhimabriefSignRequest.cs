using Aop.Api.Domain;
using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayOpenAgentZhimabriefSignRequest : IAopUploadRequest<AlipayOpenAgentZhimabriefSignResponse>, IAopRequest<AlipayOpenAgentZhimabriefSignResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string AlipayLifeName
		{
			get;
			set;
		}

		public FileItem AppDemo
		{
			get;
			set;
		}

		public string AppName
		{
			get;
			set;
		}

		public string BatchNo
		{
			get;
			set;
		}

		public FileItem BusinessLicenseAuthPic
		{
			get;
			set;
		}

		public string BusinessLicenseNo
		{
			get;
			set;
		}

		public FileItem BusinessLicensePic
		{
			get;
			set;
		}

		public string CustomUsageScene
		{
			get;
			set;
		}

		public string DateLimitation
		{
			get;
			set;
		}

		public ContactModel DrContact
		{
			get;
			set;
		}

		public string EnterpriseAlias
		{
			get;
			set;
		}

		public FileItem EnterpriseLogo
		{
			get;
			set;
		}

		public bool? LongTerm
		{
			get;
			set;
		}

		public string MccCode
		{
			get;
			set;
		}

		public ContactModel OhContact
		{
			get;
			set;
		}

		public ContactModel PrContact
		{
			get;
			set;
		}

		public FileItem SpecialLicensePic
		{
			get;
			set;
		}

		public List<string> UsageScene
		{
			get;
			set;
		}

		public List<string> WebSites
		{
			get;
			set;
		}

		public string WechatOfficialAccountName
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

		public void SetApiVersion(string apiVersion)
		{
			this.apiVersion = apiVersion;
		}

		public string GetApiVersion()
		{
			return apiVersion;
		}

		public string GetApiName()
		{
			return "alipay.open.agent.zhimabrief.sign";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("alipay_life_name", AlipayLifeName);
			aopDictionary.Add("app_name", AppName);
			aopDictionary.Add("batch_no", BatchNo);
			aopDictionary.Add("business_license_no", BusinessLicenseNo);
			aopDictionary.Add("custom_usage_scene", CustomUsageScene);
			aopDictionary.Add("date_limitation", DateLimitation);
			aopDictionary.Add("dr_contact", DrContact);
			aopDictionary.Add("enterprise_alias", EnterpriseAlias);
			aopDictionary.Add("long_term", LongTerm);
			aopDictionary.Add("mcc_code", MccCode);
			aopDictionary.Add("oh_contact", OhContact);
			aopDictionary.Add("pr_contact", PrContact);
			aopDictionary.Add("usage_scene", UsageScene);
			aopDictionary.Add("web_sites", WebSites);
			aopDictionary.Add("wechat_official_account_name", WechatOfficialAccountName);
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

		public IDictionary<string, FileItem> GetFileParameters()
		{
			IDictionary<string, FileItem> dictionary = new Dictionary<string, FileItem>();
			dictionary.Add("app_demo", AppDemo);
			dictionary.Add("business_license_auth_pic", BusinessLicenseAuthPic);
			dictionary.Add("business_license_pic", BusinessLicensePic);
			dictionary.Add("enterprise_logo", EnterpriseLogo);
			dictionary.Add("special_license_pic", SpecialLicensePic);
			return dictionary;
		}
	}
}
