using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CaseInfoCode : AopObject
	{
		[XmlElement("info_code")]
		public string InfoCode
		{
			get;
			set;
		}

		[XmlElement("info_code_desc")]
		public string InfoCodeDesc
		{
			get;
			set;
		}
	}
}
