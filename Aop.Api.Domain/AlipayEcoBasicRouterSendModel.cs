using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoBasicRouterSendModel : AopObject
	{
		[XmlElement("input")]
		public string Input
		{
			get;
			set;
		}

		[XmlElement("interface_name")]
		public string InterfaceName
		{
			get;
			set;
		}

		[XmlElement("trace_id")]
		public string TraceId
		{
			get;
			set;
		}
	}
}
