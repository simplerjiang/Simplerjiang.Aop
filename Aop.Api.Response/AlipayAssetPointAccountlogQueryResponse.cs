using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAssetPointAccountlogQueryResponse : AopResponse
	{
		[XmlElement("current_page")]
		public long CurrentPage
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlArray("point_account_logs")]
		[XmlArrayItem("point_account_log")]
		public List<PointAccountLog> PointAccountLogs
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

		[XmlElement("total_pages")]
		public long TotalPages
		{
			get;
			set;
		}
	}
}
