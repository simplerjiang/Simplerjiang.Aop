using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailTopinstanceQueryResponse : AopResponse
	{
		[XmlArray("instance_list")]
		[XmlArrayItem("instance_info")]
		public List<InstanceInfo> InstanceList
		{
			get;
			set;
		}

		[XmlElement("total_count")]
		public long TotalCount
		{
			get;
			set;
		}
	}
}
