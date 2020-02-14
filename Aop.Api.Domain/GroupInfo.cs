using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class GroupInfo : AopObject
	{
		[XmlElement("creator_uid")]
		public string CreatorUid
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("group_img")]
		public string GroupImg
		{
			get;
			set;
		}

		[XmlElement("group_name")]
		public string GroupName
		{
			get;
			set;
		}

		[XmlElement("group_threshold")]
		public long GroupThreshold
		{
			get;
			set;
		}

		[XmlElement("group_type")]
		public string GroupType
		{
			get;
			set;
		}

		[XmlElement("master_uid")]
		public string MasterUid
		{
			get;
			set;
		}
	}
}
