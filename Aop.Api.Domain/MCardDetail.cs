using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MCardDetail : AopObject
	{
		[XmlElement("available_amount")]
		public string AvailableAmount
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}
	}
}
