using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppSmsgDataSyncModel : AopObject
	{
		[XmlElement("data_one")]
		public string DataOne
		{
			get;
			set;
		}

		[XmlElement("data_two")]
		public string DataTwo
		{
			get;
			set;
		}
	}
}
