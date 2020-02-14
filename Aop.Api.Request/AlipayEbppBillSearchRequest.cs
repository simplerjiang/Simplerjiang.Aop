using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayEbppBillSearchRequest : IAopRequest<AlipayEbppBillSearchResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string BillKey
		{
			get;
			set;
		}

		public string ChargeInst
		{
			get;
			set;
		}

		public string ChargeoffInst
		{
			get;
			set;
		}

		public string CompanyId
		{
			get;
			set;
		}

		public string Extend
		{
			get;
			set;
		}

		public string OrderType
		{
			get;
			set;
		}

		public string SubOrderType
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
			return "alipay.ebpp.bill.search";
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
			aopDictionary.Add("bill_key", BillKey);
			aopDictionary.Add("charge_inst", ChargeInst);
			aopDictionary.Add("chargeoff_inst", ChargeoffInst);
			aopDictionary.Add("company_id", CompanyId);
			aopDictionary.Add("extend", Extend);
			aopDictionary.Add("order_type", OrderType);
			aopDictionary.Add("sub_order_type", SubOrderType);
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
