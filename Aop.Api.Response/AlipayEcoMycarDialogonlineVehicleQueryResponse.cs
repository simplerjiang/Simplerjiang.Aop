using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarDialogonlineVehicleQueryResponse : AopResponse
	{
		[XmlElement("factory_date")]
		public string FactoryDate
		{
			get;
			set;
		}

		[XmlElement("lib_id")]
		public string LibId
		{
			get;
			set;
		}

		[XmlElement("manufacturer")]
		public string Manufacturer
		{
			get;
			set;
		}

		[XmlElement("resident_city")]
		public string ResidentCity
		{
			get;
			set;
		}

		[XmlElement("vi_brand")]
		public string ViBrand
		{
			get;
			set;
		}

		[XmlElement("vi_cc")]
		public string ViCc
		{
			get;
			set;
		}

		[XmlElement("vi_id")]
		public string ViId
		{
			get;
			set;
		}

		[XmlElement("vi_mileage")]
		public string ViMileage
		{
			get;
			set;
		}

		[XmlElement("vi_model")]
		public string ViModel
		{
			get;
			set;
		}

		[XmlElement("vi_series")]
		public string ViSeries
		{
			get;
			set;
		}

		[XmlElement("vi_time")]
		public string ViTime
		{
			get;
			set;
		}
	}
}
