using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMemberDataIsvCreateModel : AopObject
	{
		[XmlElement("gmt_member_card_last_active")]
		public string GmtMemberCardLastActive
		{
			get;
			set;
		}

		[XmlElement("gmt_merber_card_create")]
		public string GmtMerberCardCreate
		{
			get;
			set;
		}

		[XmlElement("member_card_id")]
		public string MemberCardId
		{
			get;
			set;
		}

		[XmlElement("member_card_type")]
		public string MemberCardType
		{
			get;
			set;
		}

		[XmlElement("member_ship")]
		public MemberShip MemberShip
		{
			get;
			set;
		}

		[XmlElement("member_source")]
		public string MemberSource
		{
			get;
			set;
		}

		[XmlElement("member_source_desc")]
		public string MemberSourceDesc
		{
			get;
			set;
		}

		[XmlElement("member_status")]
		public string MemberStatus
		{
			get;
			set;
		}

		[XmlElement("outer_member_info")]
		public OuterMemberInfo OuterMemberInfo
		{
			get;
			set;
		}

		[XmlElement("parter_id")]
		public string ParterId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}
