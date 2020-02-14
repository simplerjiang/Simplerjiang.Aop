using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailMallCdpQueryResponse : AopResponse
	{
		[XmlArray("cdp_content_list")]
		[XmlArrayItem("cdp_display_content")]
		public List<CdpDisplayContent> CdpContentList
		{
			get;
			set;
		}
	}
}
