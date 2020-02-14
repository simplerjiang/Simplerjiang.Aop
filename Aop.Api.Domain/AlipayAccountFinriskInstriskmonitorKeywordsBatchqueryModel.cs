using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel : AopObject
	{
		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}
	}
}
