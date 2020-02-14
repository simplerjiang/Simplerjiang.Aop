using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppProdmodeInstshortnameQueryModel : AopObject
	{
		[XmlElement("chargeinst_cn_name")]
		public string ChargeinstCnName
		{
			get;
			set;
		}
	}
}
