using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishGroupInfo : AopObject
	{
		[XmlElement("create_user")]
		public string CreateUser
		{
			get;
			set;
		}

		[XmlArray("detail_list")]
		[XmlArrayItem("kbdish_group_detail_info")]
		public List<KbdishGroupDetailInfo> DetailList
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

		[XmlElement("group_name")]
		public string GroupName
		{
			get;
			set;
		}

		[XmlElement("group_rule")]
		public string GroupRule
		{
			get;
			set;
		}

		[XmlElement("group_version")]
		public string GroupVersion
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("unit_count_limit")]
		public string UnitCountLimit
		{
			get;
			set;
		}

		[XmlElement("update_user")]
		public string UpdateUser
		{
			get;
			set;
		}
	}
}
