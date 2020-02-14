using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayTransferThirdpartyBillCreateRequest : IAopRequest<AlipayTransferThirdpartyBillCreateResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string Amount
		{
			get;
			set;
		}

		public string Currency
		{
			get;
			set;
		}

		public string ExtParam
		{
			get;
			set;
		}

		public string Memo
		{
			get;
			set;
		}

		public string PartnerId
		{
			get;
			set;
		}

		public string PayeeAccount
		{
			get;
			set;
		}

		public string PayeeType
		{
			get;
			set;
		}

		public string PayerAccount
		{
			get;
			set;
		}

		public string PayerType
		{
			get;
			set;
		}

		public string PaymentId
		{
			get;
			set;
		}

		public string PaymentSource
		{
			get;
			set;
		}

		public string Title
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
			return "alipay.transfer.thirdparty.bill.create";
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
			aopDictionary.Add("amount", Amount);
			aopDictionary.Add("currency", Currency);
			aopDictionary.Add("ext_param", ExtParam);
			aopDictionary.Add("memo", Memo);
			aopDictionary.Add("partner_id", PartnerId);
			aopDictionary.Add("payee_account", PayeeAccount);
			aopDictionary.Add("payee_type", PayeeType);
			aopDictionary.Add("payer_account", PayerAccount);
			aopDictionary.Add("payer_type", PayerType);
			aopDictionary.Add("payment_id", PaymentId);
			aopDictionary.Add("payment_source", PaymentSource);
			aopDictionary.Add("title", Title);
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
