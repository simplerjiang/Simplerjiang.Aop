using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiSalesKbassetStuffProduceorderBatchqueryModel : AopObject
	{
		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}
	}
}
