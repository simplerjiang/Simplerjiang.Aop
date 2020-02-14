using Aop.Api.Request;

namespace Aop.Api
{
	public interface IAopClient
	{
		T Execute<T>(IAopRequest<T> request) where T : AopResponse;

		T Execute<T>(IAopRequest<T> request, string session) where T : AopResponse;

		T Execute<T>(IAopRequest<T> request, string session, string appAuthToken) where T : AopResponse;

		T pageExecute<T>(IAopRequest<T> request) where T : AopResponse;

		T pageExecute<T>(IAopRequest<T> request, string session, string reqMethod) where T : AopResponse;

		T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse;
	}
}
