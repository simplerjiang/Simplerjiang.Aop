using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayEbppPdeductPayRequest : IAopRequest<AlipayEbppPdeductPayResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string AgentChannel
		{
			get;
			set;
		}

		public string AgentCode
		{
			get;
			set;
		}

		public string AgreementId
		{
			get;
			set;
		}

		public string BillDate
		{
			get;
			set;
		}

		public string BillKey
		{
			get;
			set;
		}

		public string ExtendField
		{
			get;
			set;
		}

		public string FineAmount
		{
			get;
			set;
		}

		public string Memo
		{
			get;
			set;
		}

		public string OutOrderNo
		{
			get;
			set;
		}

		public string PayAmount
		{
			get;
			set;
		}

		public string Pid
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

		public string GetApiName()
		{
			return "alipay.ebpp.pdeduct.pay";
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
			aopDictionary.Add("agent_channel", AgentChannel);
			aopDictionary.Add("agent_code", AgentCode);
			aopDictionary.Add("agreement_id", AgreementId);
			aopDictionary.Add("bill_date", BillDate);
			aopDictionary.Add("bill_key", BillKey);
			aopDictionary.Add("extend_field", ExtendField);
			aopDictionary.Add("fine_amount", FineAmount);
			aopDictionary.Add("memo", Memo);
			aopDictionary.Add("out_order_no", OutOrderNo);
			aopDictionary.Add("pay_amount", PayAmount);
			aopDictionary.Add("pid", Pid);
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
	}
}
