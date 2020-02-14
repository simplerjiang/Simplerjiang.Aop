using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoRenthouseCommunityInfoSyncResponse : AopResponse
	{
		[XmlElement("comm_req_id")]
		public string CommReqId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public long Status
		{
			get;
			set;
		}
	}
}
