using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceAntdacEasyserviceQueryModel : AopObject
	{
		[XmlElement("method_id")]
		public string MethodId
		{
			get;
			set;
		}

		[XmlElement("parameter_json")]
		public string ParameterJson
		{
			get;
			set;
		}
	}
}
