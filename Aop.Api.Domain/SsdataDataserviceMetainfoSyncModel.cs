using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceMetainfoSyncModel : AopObject
	{
		[XmlElement("meta_info")]
		public string MetaInfo
		{
			get;
			set;
		}
	}
}
