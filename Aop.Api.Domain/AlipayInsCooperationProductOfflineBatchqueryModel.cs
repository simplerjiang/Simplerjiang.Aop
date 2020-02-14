using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsCooperationProductOfflineBatchqueryModel : AopObject
	{
		[XmlElement("inst_id")]
		public string InstId
		{
			get;
			set;
		}
	}
}
