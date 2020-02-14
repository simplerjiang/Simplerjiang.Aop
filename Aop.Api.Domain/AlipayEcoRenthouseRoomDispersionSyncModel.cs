using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseRoomDispersionSyncModel : AopObject
	{
		[XmlElement("ali_short_num")]
		public string AliShortNum
		{
			get;
			set;
		}

		[XmlElement("bedroom_count")]
		public long BedroomCount
		{
			get;
			set;
		}

		[XmlElement("checkin_time")]
		public string CheckinTime
		{
			get;
			set;
		}

		[XmlElement("comm_req_id")]
		public string CommReqId
		{
			get;
			set;
		}

		[XmlElement("commission")]
		public string Commission
		{
			get;
			set;
		}

		[XmlElement("commission_type")]
		public string CommissionType
		{
			get;
			set;
		}

		[XmlElement("community_code")]
		public string CommunityCode
		{
			get;
			set;
		}

		[XmlElement("fee_remark")]
		public string FeeRemark
		{
			get;
			set;
		}

		[XmlElement("flat_area")]
		public string FlatArea
		{
			get;
			set;
		}

		[XmlElement("flat_building")]
		public string FlatBuilding
		{
			get;
			set;
		}

		[XmlArray("flat_configs")]
		[XmlArrayItem("string")]
		public List<string> FlatConfigs
		{
			get;
			set;
		}

		[XmlElement("flat_unit")]
		public string FlatUnit
		{
			get;
			set;
		}

		[XmlElement("floor_count")]
		public long FloorCount
		{
			get;
			set;
		}

		[XmlElement("foregift_amount")]
		public string ForegiftAmount
		{
			get;
			set;
		}

		[XmlElement("free_begin_date")]
		public string FreeBeginDate
		{
			get;
			set;
		}

		[XmlElement("free_end_date")]
		public string FreeEndDate
		{
			get;
			set;
		}

		[XmlArray("images")]
		[XmlArrayItem("string")]
		public List<string> Images
		{
			get;
			set;
		}

		[XmlElement("intro")]
		public string Intro
		{
			get;
			set;
		}

		[XmlElement("max_lease_time")]
		public string MaxLeaseTime
		{
			get;
			set;
		}

		[XmlElement("min_rent_days")]
		public long MinRentDays
		{
			get;
			set;
		}

		[XmlArray("other_amount")]
		[XmlArrayItem("eco_renthouse_other_amount")]
		public List<EcoRenthouseOtherAmount> OtherAmount
		{
			get;
			set;
		}

		[XmlElement("owners_name")]
		public string OwnersName
		{
			get;
			set;
		}

		[XmlElement("owners_tel")]
		public string OwnersTel
		{
			get;
			set;
		}

		[XmlElement("parlor_count")]
		public long ParlorCount
		{
			get;
			set;
		}

		[XmlElement("pay_type")]
		public long PayType
		{
			get;
			set;
		}

		[XmlArray("pay_type_list")]
		[XmlArrayItem("eco_dis_renthousepay_type_list")]
		public List<EcoDisRenthousepayTypeList> PayTypeList
		{
			get;
			set;
		}

		[XmlElement("rent_status")]
		public long RentStatus
		{
			get;
			set;
		}

		[XmlElement("rent_type")]
		public long RentType
		{
			get;
			set;
		}

		[XmlElement("room_amount")]
		public string RoomAmount
		{
			get;
			set;
		}

		[XmlElement("room_area")]
		public string RoomArea
		{
			get;
			set;
		}

		[XmlElement("room_code")]
		public long RoomCode
		{
			get;
			set;
		}

		[XmlArray("room_configs")]
		[XmlArrayItem("string")]
		public List<string> RoomConfigs
		{
			get;
			set;
		}

		[XmlElement("room_face")]
		public long RoomFace
		{
			get;
			set;
		}

		[XmlElement("room_name")]
		public string RoomName
		{
			get;
			set;
		}

		[XmlElement("room_num")]
		public string RoomNum
		{
			get;
			set;
		}

		[XmlElement("room_status")]
		public long RoomStatus
		{
			get;
			set;
		}

		[XmlElement("room_store_no")]
		public string RoomStoreNo
		{
			get;
			set;
		}

		[XmlElement("toilet_count")]
		public long ToiletCount
		{
			get;
			set;
		}

		[XmlElement("total_floor_count")]
		public string TotalFloorCount
		{
			get;
			set;
		}
	}
}
