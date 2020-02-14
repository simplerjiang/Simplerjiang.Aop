using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPcreditHuabeiPromoQueryResponse : AopResponse
	{
		[XmlElement("facescore")]
		public string Facescore
		{
			get;
			set;
		}
	}
}
