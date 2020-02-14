using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertContentShareCode : AopObject
	{
		[XmlElement("share_code_desc")]
		public string ShareCodeDesc
		{
			get;
			set;
		}
	}
}
