using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiSalesKbassetStuffProduceqrcodeBatchqueryResponse : AopResponse
	{
		[XmlElement("has_next_page")]
		public bool HasNextPage
		{
			get;
			set;
		}

		[XmlArray("list")]
		[XmlArrayItem("access_produce_qrcode")]
		public List<AccessProduceQrcode> List
		{
			get;
			set;
		}
	}
}
