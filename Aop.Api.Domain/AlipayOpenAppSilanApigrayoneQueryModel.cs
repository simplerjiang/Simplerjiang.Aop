using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppSilanApigrayoneQueryModel : AopObject
	{
		[XmlElement("param_1")]
		public string Param1
		{
			get;
			set;
		}
	}
}
