using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayPcreditLoanCollateralCarQueryResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("apply_no")]
		public string ApplyNo
		{
			get;
			set;
		}

		[XmlElement("car_brand_id")]
		public string CarBrandId
		{
			get;
			set;
		}

		[XmlElement("car_color")]
		public string CarColor
		{
			get;
			set;
		}

		[XmlElement("car_engine_no")]
		public string CarEngineNo
		{
			get;
			set;
		}

		[XmlElement("car_mileage")]
		public long CarMileage
		{
			get;
			set;
		}

		[XmlElement("car_model_id")]
		public string CarModelId
		{
			get;
			set;
		}

		[XmlElement("car_reg_date")]
		public string CarRegDate
		{
			get;
			set;
		}

		[XmlElement("car_series_id")]
		public string CarSeriesId
		{
			get;
			set;
		}

		[XmlElement("car_vin")]
		public string CarVin
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("created_time")]
		public string CreatedTime
		{
			get;
			set;
		}

		[XmlElement("lic_plate_address")]
		public string LicPlateAddress
		{
			get;
			set;
		}

		[XmlElement("lic_plate_no")]
		public string LicPlateNo
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
