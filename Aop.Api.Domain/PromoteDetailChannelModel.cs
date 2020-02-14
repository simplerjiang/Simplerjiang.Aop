using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromoteDetailChannelModel : AopObject
	{
		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlElement("channel_name")]
		public string ChannelName
		{
			get;
			set;
		}

		[XmlElement("part_promote_data")]
		public PromoteDataModel PartPromoteData
		{
			get;
			set;
		}

		[XmlElement("total_promote_data")]
		public PromoteDataModel TotalPromoteData
		{
			get;
			set;
		}
	}
}
