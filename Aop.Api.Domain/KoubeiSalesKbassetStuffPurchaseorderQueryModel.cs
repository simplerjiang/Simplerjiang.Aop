using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiSalesKbassetStuffPurchaseorderQueryModel : AopObject
	{
		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}
	}
}
