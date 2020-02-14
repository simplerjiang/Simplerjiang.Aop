using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingPassInstanceQueryResponse : AopResponse
	{
		[XmlArray("instance_list")]
		[XmlArrayItem("pass_instance_detail")]
		public List<PassInstanceDetail> InstanceList
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
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

		[XmlElement("total")]
		public long Total
		{
			get;
			set;
		}

		[XmlElement("total_page")]
		public long TotalPage
		{
			get;
			set;
		}
	}
}
