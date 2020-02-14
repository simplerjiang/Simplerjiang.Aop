using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public interface IAopUploadRequest<T> : IAopRequest<T> where T : AopResponse
	{
		IDictionary<string, FileItem> GetFileParameters();
	}
}
