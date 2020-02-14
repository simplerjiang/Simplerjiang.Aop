using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayEcapiprodDataPutRequest : IAopRequest<AlipayEcapiprodDataPutResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string Category
		{
			get;
			set;
		}

		public string CharSet
		{
			get;
			set;
		}

		public string CollectingTaskId
		{
			get;
			set;
		}

		public string EntityCode
		{
			get;
			set;
		}

		public string EntityName
		{
			get;
			set;
		}

		public string EntityType
		{
			get;
			set;
		}

		public string IsvCode
		{
			get;
			set;
		}

		public string JsonData
		{
			get;
			set;
		}

		public string OrgCode
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
			return "alipay.ecapiprod.data.put";
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
			aopDictionary.Add("category", Category);
			aopDictionary.Add("char_set", CharSet);
			aopDictionary.Add("collecting_task_id", CollectingTaskId);
			aopDictionary.Add("entity_code", EntityCode);
			aopDictionary.Add("entity_name", EntityName);
			aopDictionary.Add("entity_type", EntityType);
			aopDictionary.Add("isv_code", IsvCode);
			aopDictionary.Add("json_data", JsonData);
			aopDictionary.Add("org_code", OrgCode);
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
