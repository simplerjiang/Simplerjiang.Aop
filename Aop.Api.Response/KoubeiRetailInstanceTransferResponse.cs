using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailInstanceTransferResponse : AopResponse
	{
		[XmlArray("instance_id_list")]
		[XmlArrayItem("string")]
		public List<string> InstanceIdList
		{
			get;
			set;
		}
	}
}
