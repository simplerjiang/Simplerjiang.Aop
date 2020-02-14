using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsDataAutodamageEstimateResultDetailModel : AopObject
	{
		[XmlElement("damage_degree")]
		public string DamageDegree
		{
			get;
			set;
		}

		[XmlElement("damage_degree_desc")]
		public string DamageDegreeDesc
		{
			get;
			set;
		}

		[XmlElement("damage_type")]
		public string DamageType
		{
			get;
			set;
		}

		[XmlElement("damage_type_desc")]
		public string DamageTypeDesc
		{
			get;
			set;
		}

		[XmlElement("hourly_wage")]
		public string HourlyWage
		{
			get;
			set;
		}

		[XmlElement("old_recycle")]
		public bool OldRecycle
		{
			get;
			set;
		}

		[XmlElement("origin_images")]
		public string OriginImages
		{
			get;
			set;
		}

		[XmlElement("parts_cost")]
		public string PartsCost
		{
			get;
			set;
		}

		[XmlElement("parts_id")]
		public string PartsId
		{
			get;
			set;
		}

		[XmlElement("parts_manage_fee")]
		public string PartsManageFee
		{
			get;
			set;
		}

		[XmlElement("parts_name")]
		public string PartsName
		{
			get;
			set;
		}

		[XmlElement("remain_value")]
		public string RemainValue
		{
			get;
			set;
		}

		[XmlElement("repair_type")]
		public string RepairType
		{
			get;
			set;
		}

		[XmlElement("repair_type_desc")]
		public string RepairTypeDesc
		{
			get;
			set;
		}
	}
}
