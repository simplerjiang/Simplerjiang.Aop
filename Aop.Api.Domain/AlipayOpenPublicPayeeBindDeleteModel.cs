using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicPayeeBindDeleteModel : AopObject
	{
		[XmlElement("login_id")]
		public string LoginId
		{
			get;
			set;
		}

		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}
	}
}
