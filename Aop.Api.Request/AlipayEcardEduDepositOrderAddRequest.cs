using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayEcardEduDepositOrderAddRequest : IAopRequest<AlipayEcardEduDepositOrderAddResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

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

		public string AlipayUserId
		{
			get;
			set;
		}

		public string CardName
		{
			get;
			set;
		}

		public string CardNo
		{
			get;
			set;
		}

		public string DepositAmount
		{
			get;
			set;
		}

		public string MobileNo
		{
			get;
			set;
		}

		public string PublicId
		{
			get;
			set;
		}

		public string ShareMobileNo
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
			return "alipay.ecard.edu.deposit.order.add";
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
			aopDictionary.Add("agent_code", AgentCode);
			aopDictionary.Add("agreement_id", AgreementId);
			aopDictionary.Add("alipay_user_id", AlipayUserId);
			aopDictionary.Add("card_name", CardName);
			aopDictionary.Add("card_no", CardNo);
			aopDictionary.Add("deposit_amount", DepositAmount);
			aopDictionary.Add("mobile_no", MobileNo);
			aopDictionary.Add("public_id", PublicId);
			aopDictionary.Add("share_mobile_no", ShareMobileNo);
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
