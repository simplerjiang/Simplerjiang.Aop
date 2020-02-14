using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniTinyappExistQueryModel : AopObject
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}
	}
}
