using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayOpenPublicLifeAgentCreateRequest : IAopUploadRequest<AlipayOpenPublicLifeAgentCreateResponse>, IAopRequest<AlipayOpenPublicLifeAgentCreateResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string Account
		{
			get;
			set;
		}

		public FileItem BackgroundPic
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

		public string ContactEmail
		{
			get;
			set;
		}

		public string ContactMobile
		{
			get;
			set;
		}

		public string ContactName
		{
			get;
			set;
		}

		public FileItem LogoPic
		{
			get;
			set;
		}

		public string MccCode
		{
			get;
			set;
		}

		public string OutBizNo
		{
			get;
			set;
		}

		public FileItem OwnIntellectualPic
		{
			get;
			set;
		}

		public string PublicDesc
		{
			get;
			set;
		}

		public string PublicName
		{
			get;
			set;
		}

		public FileItem ShopScenePic
		{
			get;
			set;
		}

		public FileItem ShopSignBoardPic
		{
			get;
			set;
		}

		public FileItem SpecialLicensePic
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
			return "alipay.open.public.life.agent.create";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("account", Account);
			aopDictionary.Add("business_license_no", BusinessLicenseNo);
			aopDictionary.Add("contact_email", ContactEmail);
			aopDictionary.Add("contact_mobile", ContactMobile);
			aopDictionary.Add("contact_name", ContactName);
			aopDictionary.Add("mcc_code", MccCode);
			aopDictionary.Add("out_biz_no", OutBizNo);
			aopDictionary.Add("public_desc", PublicDesc);
			aopDictionary.Add("public_name", PublicName);
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
			dictionary.Add("background_pic", BackgroundPic);
			dictionary.Add("business_license_auth_pic", BusinessLicenseAuthPic);
			dictionary.Add("business_license_pic", BusinessLicensePic);
			dictionary.Add("logo_pic", LogoPic);
			dictionary.Add("own_intellectual_pic", OwnIntellectualPic);
			dictionary.Add("shop_scene_pic", ShopScenePic);
			dictionary.Add("shop_sign_board_pic", ShopSignBoardPic);
			dictionary.Add("special_license_pic", SpecialLicensePic);
			return dictionary;
		}
	}
}
