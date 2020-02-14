using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataFindataOperatorChannelQueryResponse : AopResponse
	{
		[XmlArray("channels")]
		[XmlArrayItem("operator_channel_info")]
		public List<OperatorChannelInfo> Channels
		{
			get;
			set;
		}
	}
}
