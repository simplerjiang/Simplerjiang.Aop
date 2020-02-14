using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccountFreeze : AopObject
	{
		[XmlElement("freeze_amount")]
		public string FreezeAmount
		{
			get;
			set;
		}

		[XmlElement("freeze_name")]
		public string FreezeName
		{
			get;
			set;
		}

		[XmlElement("freeze_type")]
		public string FreezeType
		{
			get;
			set;
		}
	}
}
