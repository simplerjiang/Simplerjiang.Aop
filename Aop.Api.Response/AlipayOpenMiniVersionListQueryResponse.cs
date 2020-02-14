using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniVersionListQueryResponse : AopResponse
	{
		[XmlArray("app_versions")]
		[XmlArrayItem("string")]
		public List<string> AppVersions
		{
			get;
			set;
		}
	}
}
