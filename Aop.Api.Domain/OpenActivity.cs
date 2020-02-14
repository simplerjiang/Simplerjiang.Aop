using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenActivity : AopObject
	{
		[XmlElement("activity_end_date")]
		public string ActivityEndDate
		{
			get;
			set;
		}

		[XmlElement("activity_id")]
		public string ActivityId
		{
			get;
			set;
		}

		[XmlElement("activity_name")]
		public string ActivityName
		{
			get;
			set;
		}

		[XmlElement("activity_start_date")]
		public string ActivityStartDate
		{
			get;
			set;
		}

		[XmlElement("activity_status")]
		public string ActivityStatus
		{
			get;
			set;
		}

		[XmlElement("store_id")]
		public string StoreId
		{
			get;
			set;
		}
	}
}
