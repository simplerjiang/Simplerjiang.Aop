using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RetailKbcodeCreateVo : AopObject
	{
		[XmlElement("code_tip")]
		public string CodeTip
		{
			get;
			set;
		}

		[XmlElement("salesman")]
		public string Salesman
		{
			get;
			set;
		}
	}
}
