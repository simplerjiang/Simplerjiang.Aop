using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityDataInfoIpaddrinfoQueryResponse : AopResponse
	{
		[XmlElement("ip_addr_lbs_info")]
		public IpAddrLbsInfo IpAddrLbsInfo
		{
			get;
			set;
		}
	}
}
