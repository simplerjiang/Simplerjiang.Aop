using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AccPayeeInfo : AopObject
	{
		[XmlElement("payee_account")]
		public string PayeeAccount
		{
			get;
			set;
		}

		[XmlElement("payee_name")]
		public string PayeeName
		{
			get;
			set;
		}
	}
}
