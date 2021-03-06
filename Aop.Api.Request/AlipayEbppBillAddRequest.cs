using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayEbppBillAddRequest : IAopRequest<AlipayEbppBillAddResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string BankBillNo
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

		public string ChargeInst
		{
			get;
			set;
		}

		public string ExtendField
		{
			get;
			set;
		}

		public string MerchantOrderNo
		{
			get;
			set;
		}

		public string Mobile
		{
			get;
			set;
		}

		public string OrderType
		{
			get;
			set;
		}

		public string OwnerName
		{
			get;
			set;
		}

		public string PayAmount
		{
			get;
			set;
		}

		public string ServiceAmount
		{
			get;
			set;
		}

		public string SubOrderType
		{
			get;
			set;
		}

		public string TrafficLocation
		{
			get;
			set;
		}

		public string TrafficRegulations
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
			return "alipay.ebpp.bill.add";
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
			aopDictionary.Add("bank_bill_no", BankBillNo);
			aopDictionary.Add("bill_date", BillDate);
			aopDictionary.Add("bill_key", BillKey);
			aopDictionary.Add("charge_inst", ChargeInst);
			aopDictionary.Add("extend_field", ExtendField);
			aopDictionary.Add("merchant_order_no", MerchantOrderNo);
			aopDictionary.Add("mobile", Mobile);
			aopDictionary.Add("order_type", OrderType);
			aopDictionary.Add("owner_name", OwnerName);
			aopDictionary.Add("pay_amount", PayAmount);
			aopDictionary.Add("service_amount", ServiceAmount);
			aopDictionary.Add("sub_order_type", SubOrderType);
			aopDictionary.Add("traffic_location", TrafficLocation);
			aopDictionary.Add("traffic_regulations", TrafficRegulations);
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
