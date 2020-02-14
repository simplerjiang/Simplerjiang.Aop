using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenFormFieldDO : AopObject
	{
		[XmlElement("optional")]
		public string Optional
		{
			get;
			set;
		}

		[XmlElement("required")]
		public string Required
		{
			get;
			set;
		}
	}
}
