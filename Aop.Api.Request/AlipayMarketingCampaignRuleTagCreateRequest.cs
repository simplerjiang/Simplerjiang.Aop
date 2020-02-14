using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayMarketingCampaignRuleTagCreateRequest : IAopUploadRequest<AlipayMarketingCampaignRuleTagCreateResponse>, IAopRequest<AlipayMarketingCampaignRuleTagCreateResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public FileItem Customerdata
		{
			get;
			set;
		}

		public string Mpid
		{
			get;
			set;
		}

		public string Operatetype
		{
			get;
			set;
		}

		public string Selftag
		{
			get;
			set;
		}

		public string Tagdesc
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
			return "alipay.marketing.campaign.rule.tag.create";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("mpid", Mpid);
			aopDictionary.Add("operatetype", Operatetype);
			aopDictionary.Add("selftag", Selftag);
			aopDictionary.Add("tagdesc", Tagdesc);
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
			dictionary.Add("customerdata", Customerdata);
			return dictionary;
		}
	}
}
