using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayOpenPublicLifeCreateRequest : IAopUploadRequest<AlipayOpenPublicLifeCreateResponse>, IAopRequest<AlipayOpenPublicLifeCreateResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public FileItem Background
		{
			get;
			set;
		}

		public string ContactEmail
		{
			get;
			set;
		}

		public string ContactName
		{
			get;
			set;
		}

		public string ContactTel
		{
			get;
			set;
		}

		public string CustomerTel
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public string ExtendData
		{
			get;
			set;
		}

		public string LifeName
		{
			get;
			set;
		}

		public FileItem Logo
		{
			get;
			set;
		}

		public string MccCode
		{
			get;
			set;
		}

		public string PublicBizType
		{
			get;
			set;
		}

		public string ShowStyle
		{
			get;
			set;
		}

		public string UserId
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
			return "alipay.open.public.life.create";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("contact_email", ContactEmail);
			aopDictionary.Add("contact_name", ContactName);
			aopDictionary.Add("contact_tel", ContactTel);
			aopDictionary.Add("customer_tel", CustomerTel);
			aopDictionary.Add("description", Description);
			aopDictionary.Add("extend_data", ExtendData);
			aopDictionary.Add("life_name", LifeName);
			aopDictionary.Add("mcc_code", MccCode);
			aopDictionary.Add("public_biz_type", PublicBizType);
			aopDictionary.Add("show_style", ShowStyle);
			aopDictionary.Add("user_id", UserId);
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
			dictionary.Add("background", Background);
			dictionary.Add("logo", Logo);
			return dictionary;
		}
	}
}
