using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicSinglearticleDataBatchqueryModel : AopObject
	{
		[XmlElement("begin_date")]
		public string BeginDate
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}
	}
}
