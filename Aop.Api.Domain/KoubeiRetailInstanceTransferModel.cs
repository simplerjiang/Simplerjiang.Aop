using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailInstanceTransferModel : AopObject
	{
		[XmlArray("instance_id_list")]
		[XmlArrayItem("string")]
		public List<string> InstanceIdList
		{
			get;
			set;
		}

		[XmlElement("instance_type")]
		public string InstanceType
		{
			get;
			set;
		}
	}
}
