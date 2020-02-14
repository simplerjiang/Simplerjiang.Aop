using System.Collections.Generic;

namespace Aop.Api.Request
{
	public interface IAopRequest<T> where T : AopResponse
	{
		string GetNotifyUrl();

		void SetNotifyUrl(string notifyUrl);

		string GetReturnUrl();

		void SetReturnUrl(string returnUrl);

		void SetNeedEncrypt(bool needEncrypt);

		bool GetNeedEncrypt();

		string GetApiName();

		string GetTerminalType();

		void SetTerminalType(string terminalType);

		string GetTerminalInfo();

		void SetTerminalInfo(string terminalInfo);

		string GetProdCode();

		void SetProdCode(string prodCode);

		void SetApiVersion(string apiVersion);

		string GetApiVersion();

		IDictionary<string, string> GetParameters();

		AopObject GetBizModel();

		void SetBizModel(AopObject bizModel);
	}
}
