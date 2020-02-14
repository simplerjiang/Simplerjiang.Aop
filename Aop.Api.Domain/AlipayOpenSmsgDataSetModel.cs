using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenSmsgDataSetModel : AopObject
	{
		[XmlElement("paramone")]
		public string Paramone
		{
			get;
			set;
		}

		[XmlElement("paramtwo")]
		public string Paramtwo
		{
			get;
			set;
		}
	}
}
