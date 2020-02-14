using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAgentOrderQueryModel : AopObject
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}
	}
}
