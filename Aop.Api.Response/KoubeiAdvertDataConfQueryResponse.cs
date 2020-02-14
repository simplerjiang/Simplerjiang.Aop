using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertDataConfQueryResponse : AopResponse
	{
		[XmlArray("channel_types")]
		[XmlArrayItem("kbadvert_channel_type_response")]
		public List<KbadvertChannelTypeResponse> ChannelTypes
		{
			get;
			set;
		}

		[XmlArray("commission_limits")]
		[XmlArrayItem("kbadvert_commission_limit")]
		public List<KbadvertCommissionLimit> CommissionLimits
		{
			get;
			set;
		}
	}
}
