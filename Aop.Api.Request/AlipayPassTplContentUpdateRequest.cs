using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayPassTplContentUpdateRequest : IAopRequest<AlipayPassTplContentUpdateResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string ChannelId
		{
			get;
			set;
		}

		public string SerialNumber
		{
			get;
			set;
		}

		public string Status
		{
			get;
			set;
		}

		public string TplParams
		{
			get;
			set;
		}

		public string VerifyCode
		{
			get;
			set;
		}

		public string VerifyType
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
			return "alipay.pass.tpl.content.update";
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
			aopDictionary.Add("channel_id", ChannelId);
			aopDictionary.Add("serial_number", SerialNumber);
			aopDictionary.Add("status", Status);
			aopDictionary.Add("tpl_params", TplParams);
			aopDictionary.Add("verify_code", VerifyCode);
			aopDictionary.Add("verify_type", VerifyType);
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
