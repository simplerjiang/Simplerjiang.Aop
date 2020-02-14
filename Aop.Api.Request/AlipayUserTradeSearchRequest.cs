using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayUserTradeSearchRequest : IAopRequest<AlipayUserTradeSearchResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string AlipayOrderNo
		{
			get;
			set;
		}

		public string EndTime
		{
			get;
			set;
		}

		public string MerchantOrderNo
		{
			get;
			set;
		}

		public string OrderFrom
		{
			get;
			set;
		}

		public string OrderStatus
		{
			get;
			set;
		}

		public string OrderType
		{
			get;
			set;
		}

		public string PageNo
		{
			get;
			set;
		}

		public string PageSize
		{
			get;
			set;
		}

		public string StartTime
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
			return "alipay.user.trade.search";
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
			aopDictionary.Add("alipay_order_no", AlipayOrderNo);
			aopDictionary.Add("end_time", EndTime);
			aopDictionary.Add("merchant_order_no", MerchantOrderNo);
			aopDictionary.Add("order_from", OrderFrom);
			aopDictionary.Add("order_status", OrderStatus);
			aopDictionary.Add("order_type", OrderType);
			aopDictionary.Add("page_no", PageNo);
			aopDictionary.Add("page_size", PageSize);
			aopDictionary.Add("start_time", StartTime);
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
