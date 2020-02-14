using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProdmodeInstshortnameQueryResponse : AopResponse
	{
		[XmlElement("chargeinst_cn_name")]
		public string ChargeinstCnName
		{
			get;
			set;
		}

		[XmlElement("chargeinst_en_name")]
		public string ChargeinstEnName
		{
			get;
			set;
		}
	}
}
