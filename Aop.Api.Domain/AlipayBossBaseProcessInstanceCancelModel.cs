using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayBossBaseProcessInstanceCancelModel : AopObject
	{
		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
		{
			get;
			set;
		}

		[XmlElement("puid")]
		public string Puid
		{
			get;
			set;
		}
	}
}
