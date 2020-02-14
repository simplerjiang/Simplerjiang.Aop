using System;
using System.Collections;

namespace Aop.Api.Parser
{
	public interface IAopReader
	{
		bool HasReturnField(object name);

		object GetPrimitiveObject(object name);

		object GetReferenceObject(object name, Type type, DAopConvert convert);

		IList GetListObjects(string listName, string itemName, Type type, DAopConvert convert);
	}
}
