using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrDriverlicenseQueryResponse : AopResponse
	{
		[XmlElement("addr")]
		public string Addr
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
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

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("num")]
		public string Num
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

		[XmlElement("sex")]
		public string Sex
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
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

		[XmlElement("vehicle_type")]
		public string VehicleType
		{
			get;
			set;
		}
	}
}
