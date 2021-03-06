using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayAcquirePrecreateRequest : IAopRequest<AlipayAcquirePrecreateResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string Body
		{
			get;
			set;
		}

		public string ChannelParameters
		{
			get;
			set;
		}

		public string Currency
		{
			get;
			set;
		}

		public string ExtendParams
		{
			get;
			set;
		}

		public string GoodsDetail
		{
			get;
			set;
		}

		public string ItBPay
		{
			get;
			set;
		}

		public string OperatorCode
		{
			get;
			set;
		}

		public string OperatorId
		{
			get;
			set;
		}

		public string OutTradeNo
		{
			get;
			set;
		}

		public string Price
		{
			get;
			set;
		}

		public string Quantity
		{
			get;
			set;
		}

		public string RoyaltyParameters
		{
			get;
			set;
		}

		public string RoyaltyType
		{
			get;
			set;
		}

		public string SellerEmail
		{
			get;
			set;
		}

		public string SellerId
		{
			get;
			set;
		}

		public string ShowUrl
		{
			get;
			set;
		}

		public string Subject
		{
			get;
			set;
		}

		public string TotalFee
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
			return "alipay.acquire.precreate";
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
			aopDictionary.Add("body", Body);
			aopDictionary.Add("channel_parameters", ChannelParameters);
			aopDictionary.Add("currency", Currency);
			aopDictionary.Add("extend_params", ExtendParams);
			aopDictionary.Add("goods_detail", GoodsDetail);
			aopDictionary.Add("it_b_pay", ItBPay);
			aopDictionary.Add("operator_code", OperatorCode);
			aopDictionary.Add("operator_id", OperatorId);
			aopDictionary.Add("out_trade_no", OutTradeNo);
			aopDictionary.Add("price", Price);
			aopDictionary.Add("quantity", Quantity);
			aopDictionary.Add("royalty_parameters", RoyaltyParameters);
			aopDictionary.Add("royalty_type", RoyaltyType);
			aopDictionary.Add("seller_email", SellerEmail);
			aopDictionary.Add("seller_id", SellerId);
			aopDictionary.Add("show_url", ShowUrl);
			aopDictionary.Add("subject", Subject);
			aopDictionary.Add("total_fee", TotalFee);
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
