using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MedicalSvTpCardHeadInfo : AopObject
	{
		[XmlElement("header_icon")]
		public string HeaderIcon
		{
			get;
			set;
		}

		[XmlElement("header_title")]
		public string HeaderTitle
		{
			get;
			set;
		}
	}
}
