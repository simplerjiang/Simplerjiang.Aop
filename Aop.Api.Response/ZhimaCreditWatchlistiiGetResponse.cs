using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditWatchlistiiGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlArray("details")]
		[XmlArrayItem("zm_watch_list_detail")]
		public List<ZmWatchListDetail> Details
		{
			get;
			set;
		}

		[XmlElement("is_matched")]
		public bool IsMatched
		{
			get;
			set;
		}
	}
}
