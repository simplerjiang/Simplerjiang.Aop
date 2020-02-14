using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayOpenAgentMiniCreateRequest : IAopUploadRequest<AlipayOpenAgentMiniCreateResponse>, IAopRequest<AlipayOpenAgentMiniCreateResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string AppCategoryIds
		{
			get;
			set;
		}

		public string AppDesc
		{
			get;
			set;
		}

		public string AppEnglishName
		{
			get;
			set;
		}

		public FileItem AppLogo
		{
			get;
			set;
		}

		public string AppName
		{
			get;
			set;
		}

		public string AppSlogan
		{
			get;
			set;
		}

		public string BatchNo
		{
			get;
			set;
		}

		public string ServiceEmail
		{
			get;
			set;
		}

		public string ServicePhone
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
			return "alipay.open.agent.mini.create";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("app_category_ids", AppCategoryIds);
			aopDictionary.Add("app_desc", AppDesc);
			aopDictionary.Add("app_english_name", AppEnglishName);
			aopDictionary.Add("app_name", AppName);
			aopDictionary.Add("app_slogan", AppSlogan);
			aopDictionary.Add("batch_no", BatchNo);
			aopDictionary.Add("service_email", ServiceEmail);
			aopDictionary.Add("service_phone", ServicePhone);
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
			dictionary.Add("app_logo", AppLogo);
			return dictionary;
		}
	}
}
