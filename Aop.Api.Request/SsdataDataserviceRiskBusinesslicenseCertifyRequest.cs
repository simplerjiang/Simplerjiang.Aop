using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class SsdataDataserviceRiskBusinesslicenseCertifyRequest : IAopUploadRequest<SsdataDataserviceRiskBusinesslicenseCertifyResponse>, IAopRequest<SsdataDataserviceRiskBusinesslicenseCertifyResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string Address
		{
			get;
			set;
		}

		public string BizId
		{
			get;
			set;
		}

		public string CreditCode
		{
			get;
			set;
		}

		public string EntLegalName
		{
			get;
			set;
		}

		public string EntName
		{
			get;
			set;
		}

		public FileItem EntProsPic
		{
			get;
			set;
		}

		public string Expires
		{
			get;
			set;
		}

		public string ExpiresEnd
		{
			get;
			set;
		}

		public string ExpiresStart
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
			return "ssdata.dataservice.risk.businesslicense.certify";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("address", Address);
			aopDictionary.Add("biz_id", BizId);
			aopDictionary.Add("credit_code", CreditCode);
			aopDictionary.Add("ent_legal_name", EntLegalName);
			aopDictionary.Add("ent_name", EntName);
			aopDictionary.Add("expires", Expires);
			aopDictionary.Add("expires_end", ExpiresEnd);
			aopDictionary.Add("expires_start", ExpiresStart);
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
			dictionary.Add("ent_pros_pic", EntProsPic);
			return dictionary;
		}
	}
}
