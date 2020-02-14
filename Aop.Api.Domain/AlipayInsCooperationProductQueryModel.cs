using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsCooperationProductQueryModel : AopObject
	{
		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}
	}
}
