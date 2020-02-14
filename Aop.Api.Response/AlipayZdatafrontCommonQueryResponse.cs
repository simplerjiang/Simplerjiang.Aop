using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayZdatafrontCommonQueryResponse : AopResponse
	{
		[XmlElement("cache_timestamp")]
		public long CacheTimestamp
		{
			get;
			set;
		}

		[XmlElement("values")]
		public string Values
		{
			get;
			set;
		}
	}
}
