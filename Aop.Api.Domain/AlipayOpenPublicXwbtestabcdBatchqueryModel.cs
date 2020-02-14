using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicXwbtestabcdBatchqueryModel : AopObject
	{
		[XmlElement("s")]
		public string S
		{
			get;
			set;
		}
	}
}
