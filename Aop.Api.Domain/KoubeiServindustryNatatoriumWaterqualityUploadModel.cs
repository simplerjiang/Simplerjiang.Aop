using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiServindustryNatatoriumWaterqualityUploadModel : AopObject
	{
		[XmlElement("commodity_id")]
		public string CommodityId
		{
			get;
			set;
		}

		[XmlElement("current_num")]
		public long CurrentNum
		{
			get;
			set;
		}

		[XmlElement("currentnum_update_time")]
		public string CurrentnumUpdateTime
		{
			get;
			set;
		}

		[XmlElement("external_id")]
		public string ExternalId
		{
			get;
			set;
		}

		[XmlElement("footpool_cl_qualified")]
		public string FootpoolClQualified
		{
			get;
			set;
		}

		[XmlElement("footpool_cl_remain")]
		public string FootpoolClRemain
		{
			get;
			set;
		}

		[XmlElement("footpool_cl_remain_standard")]
		public string FootpoolClRemainStandard
		{
			get;
			set;
		}

		[XmlElement("limit_num")]
		public long LimitNum
		{
			get;
			set;
		}

		[XmlElement("mainpool_cl_qualified")]
		public string MainpoolClQualified
		{
			get;
			set;
		}

		[XmlElement("mainpool_cl_remain")]
		public string MainpoolClRemain
		{
			get;
			set;
		}

		[XmlElement("mainpool_cl_remain_standard")]
		public string MainpoolClRemainStandard
		{
			get;
			set;
		}

		[XmlElement("pool_volume")]
		public string PoolVolume
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
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

		[XmlElement("water_change")]
		public string WaterChange
		{
			get;
			set;
		}

		[XmlElement("water_change_percent")]
		public string WaterChangePercent
		{
			get;
			set;
		}

		[XmlElement("water_change_qualified")]
		public string WaterChangeQualified
		{
			get;
			set;
		}

		[XmlElement("water_change_standard")]
		public string WaterChangeStandard
		{
			get;
			set;
		}

		[XmlElement("water_check_time")]
		public string WaterCheckTime
		{
			get;
			set;
		}

		[XmlElement("water_ph")]
		public string WaterPh
		{
			get;
			set;
		}

		[XmlElement("water_ph_qualified")]
		public string WaterPhQualified
		{
			get;
			set;
		}

		[XmlElement("water_ph_standard")]
		public string WaterPhStandard
		{
			get;
			set;
		}

		[XmlElement("water_qualified")]
		public string WaterQualified
		{
			get;
			set;
		}

		[XmlElement("water_temperature")]
		public string WaterTemperature
		{
			get;
			set;
		}

		[XmlElement("water_temperature_qualified")]
		public string WaterTemperatureQualified
		{
			get;
			set;
		}

		[XmlElement("water_temperature_standard")]
		public string WaterTemperatureStandard
		{
			get;
			set;
		}

		[XmlElement("water_update_time")]
		public string WaterUpdateTime
		{
			get;
			set;
		}
	}
}
