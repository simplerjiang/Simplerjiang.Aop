using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenXwbtesttomsgapiSyncModel : AopObject
	{
		[XmlElement("xwb")]
		public string Xwb
		{
			get;
			set;
		}
	}
}
