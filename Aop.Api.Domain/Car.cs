using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Car : AopObject
	{
		[XmlElement("car_engine_no")]
		public string CarEngineNo
		{
			get;
			set;
		}

		[XmlElement("car_frame_no")]
		public string CarFrameNo
		{
			get;
			set;
		}

		[XmlElement("car_model_code")]
		public string CarModelCode
		{
			get;
			set;
		}

		[XmlElement("car_no")]
		public string CarNo
		{
			get;
			set;
		}

		[XmlElement("data_source")]
		public string DataSource
		{
			get;
			set;
		}

		[XmlElement("first_register_date")]
		public string FirstRegisterDate
		{
			get;
			set;
		}

		[XmlElement("license_address")]
		public string LicenseAddress
		{
			get;
			set;
		}

		[XmlElement("transfer_car")]
		public string TransferCar
		{
			get;
			set;
		}

		[XmlElement("transfer_date")]
		public string TransferDate
		{
			get;
			set;
		}

		[XmlArray("vehicle_info_list")]
		[XmlArrayItem("vehicle_info")]
		public List<VehicleInfo> VehicleInfoList
		{
			get;
			set;
		}

		[XmlElement("vehicle_type")]
		public string VehicleType
		{
			get;
			set;
		}
	}
}
