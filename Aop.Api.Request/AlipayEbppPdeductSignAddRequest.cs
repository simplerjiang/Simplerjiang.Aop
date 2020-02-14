using Aop.Api.Response;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayEbppPdeductSignAddRequest : IAopRequest<AlipayEbppPdeductSignAddResponse>
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

		public string BillKey
		{
			get;
			set;
		}

		public string BizType
		{
			get;
			set;
		}

		public string ChargeInst
		{
			get;
			set;
		}

		public string DeductProdCode
		{
			get;
			set;
		}

		public string DeductType
		{
			get;
			set;
		}

		public string ExtUserInfo
		{
			get;
			set;
		}

		public string ExtendField
		{
			get;
			set;
		}

		public string NotifyConfig
		{
			get;
			set;
		}

		public string OutAgreementId
		{
			get;
			set;
		}

		public string OwnerName
		{
			get;
			set;
		}

		public string PayConfig
		{
			get;
			set;
		}

		public string PayPasswordToken
		{
			get;
			set;
		}

		public string Pid
		{
			get;
			set;
		}

		public string SignExpireDate
		{
			get;
			set;
		}

		public string SubBizType
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
			return "alipay.ebpp.pdeduct.sign.add";
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
			aopDictionary.Add("bill_key", BillKey);
			aopDictionary.Add("biz_type", BizType);
			aopDictionary.Add("charge_inst", ChargeInst);
			aopDictionary.Add("deduct_prod_code", DeductProdCode);
			aopDictionary.Add("deduct_type", DeductType);
			aopDictionary.Add("ext_user_info", ExtUserInfo);
			aopDictionary.Add("extend_field", ExtendField);
			aopDictionary.Add("notify_config", NotifyConfig);
			aopDictionary.Add("out_agreement_id", OutAgreementId);
			aopDictionary.Add("owner_name", OwnerName);
			aopDictionary.Add("pay_config", PayConfig);
			aopDictionary.Add("pay_password_token", PayPasswordToken);
			aopDictionary.Add("pid", Pid);
			aopDictionary.Add("sign_expire_date", SignExpireDate);
			aopDictionary.Add("sub_biz_type", SubBizType);
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
