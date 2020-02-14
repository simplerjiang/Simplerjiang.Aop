using Aop.Api.Request;

namespace Aop.Api.Parser
{
	public interface IAopParser<T> where T : AopResponse
	{
		T Parse(string body, string charset);

		SignItem GetSignItem(IAopRequest<T> request, string responseBody);

		string EncryptSourceData(IAopRequest<T> request, string body, string encryptType, string encryptKey, string charset);
	}
}
