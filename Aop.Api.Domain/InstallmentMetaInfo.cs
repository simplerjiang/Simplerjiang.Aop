using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InstallmentMetaInfo : AopObject
	{
		[XmlElement("end_term")]
		public long EndTerm
		{
			get;
			set;
		}

		[XmlElement("start_term")]
		public long StartTerm
		{
			get;
			set;
		}

		[XmlElement("value")]
		public string Value
		{
			get;
			set;
		}
	}
}
