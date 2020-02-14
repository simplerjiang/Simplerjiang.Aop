using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOverseasTaxOrderPayResponse : AopResponse
	{
		[XmlElement("tax_no")]
		public string TaxNo
		{
			get;
			set;
		}
	}
}
