using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdSeAppletQueryResponse : AopResponse
	{
		[XmlElement("apdu_commands")]
		public string ApduCommands
		{
			get;
			set;
		}

		[XmlElement("opt_type")]
		public long OptType
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public long ResultCode
		{
			get;
			set;
		}

		[XmlElement("step")]
		public long Step
		{
			get;
			set;
		}

		[XmlElement("step_code")]
		public long StepCode
		{
			get;
			set;
		}

		[XmlElement("sub_opt_type")]
		public long SubOptType
		{
			get;
			set;
		}

		[XmlElement("total_step")]
		public long TotalStep
		{
			get;
			set;
		}
	}
}
