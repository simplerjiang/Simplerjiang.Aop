using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppYiyiyiwuQueryModel : AopObject
	{
		[XmlElement("rucan")]
		public string Rucan
		{
			get;
			set;
		}
	}
}
