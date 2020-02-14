using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeCustomsQueryModel : AopObject
	{
		[XmlElement("out_request_nos")]
		public string OutRequestNos
		{
			get;
			set;
		}
	}
}
