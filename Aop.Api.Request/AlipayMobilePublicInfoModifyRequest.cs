using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayMobilePublicInfoModifyRequest : IAopRequest<AlipayMobilePublicInfoModifyResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string AppName
		{
			get;
			set;
		}

		public string AuthPic
		{
			get;
			set;
		}

		public string LicenseUrl
		{
			get;
			set;
		}

		public string LogoUrl
		{
			get;
			set;
		}

		public string PublicGreeting
		{
			get;
			set;
		}

		public string ShopPic1
		{
			get;
			set;
		}

		public string ShopPic2
		{
			get;
			set;
		}

		public string ShopPic3
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
			return "alipay.mobile.public.info.modify";
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
			aopDictionary.Add("app_name", AppName);
			aopDictionary.Add("auth_pic", AuthPic);
			aopDictionary.Add("license_url", LicenseUrl);
			aopDictionary.Add("logo_url", LogoUrl);
			aopDictionary.Add("public_greeting", PublicGreeting);
			aopDictionary.Add("shop_pic1", ShopPic1);
			aopDictionary.Add("shop_pic2", ShopPic2);
			aopDictionary.Add("shop_pic3", ShopPic3);
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
