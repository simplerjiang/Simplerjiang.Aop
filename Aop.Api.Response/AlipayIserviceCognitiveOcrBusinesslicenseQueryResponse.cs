using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrBusinesslicenseQueryResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("business")]
		public string Business
		{
			get;
			set;
		}

		[XmlElement("captial")]
		public string Captial
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

		[XmlElement("establish_date")]
		public string EstablishDate
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

		[XmlElement("person")]
		public string Person
		{
			get;
			set;
		}

		[XmlElement("reg_num")]
		public string RegNum
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

		[XmlElement("valid_period")]
		public string ValidPeriod
		{
			get;
			set;
		}
	}
}
