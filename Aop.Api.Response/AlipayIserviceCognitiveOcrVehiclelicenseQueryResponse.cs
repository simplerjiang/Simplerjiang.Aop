using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrVehiclelicenseQueryResponse : AopResponse
	{
		[XmlElement("engine_num")]
		public string EngineNum
		{
			get;
			set;
		}

		[XmlElement("error_content")]
		public string ErrorContent
		{
			get;
			set;
		}

		[XmlElement("issue_date")]
		public string IssueDate
		{
			get;
			set;
		}

		[XmlElement("model")]
		public string Model
		{
			get;
			set;
		}

		[XmlElement("owner")]
		public string Owner
		{
			get;
			set;
		}

		[XmlElement("plate_num")]
		public string PlateNum
		{
			get;
			set;
		}

		[XmlElement("register_date")]
		public string RegisterDate
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

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}

		[XmlElement("trace_id")]
		public string TraceId
		{
			get;
			set;
		}

		[XmlElement("use_character")]
		public string UseCharacter
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

		[XmlElement("vin")]
		public string Vin
		{
			get;
			set;
		}
	}
}
