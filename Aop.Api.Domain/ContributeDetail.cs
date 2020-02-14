using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ContributeDetail : AopObject
	{
		[XmlElement("contribute_amount")]
		public string ContributeAmount
		{
			get;
			set;
		}

		[XmlElement("contribute_type")]
		public string ContributeType
		{
			get;
			set;
		}
	}
}
