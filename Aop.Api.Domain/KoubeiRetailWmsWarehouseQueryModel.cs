using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsWarehouseQueryModel : AopObject
	{
		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlElement("own_type")]
		public string OwnType
		{
			get;
			set;
		}

		[XmlElement("owner_id")]
		public string OwnerId
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public long PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("warehouse_code")]
		public string WarehouseCode
		{
			get;
			set;
		}
	}
}
