using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAntpaasUseridGetModel : AopObject
	{
		[XmlElement("logon_id")]
		public string LogonId
		{
			get;
			set;
		}
	}
}
