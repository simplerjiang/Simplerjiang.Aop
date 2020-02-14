using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppProdmodeReconconfQueryResponse : AopResponse
	{
		[XmlElement("check_depend")]
		public string CheckDepend
		{
			get;
			set;
		}

		[XmlElement("check_grade")]
		public string CheckGrade
		{
			get;
			set;
		}

		[XmlElement("clear_grade")]
		public string ClearGrade
		{
			get;
			set;
		}

		[XmlElement("cut_hour")]
		public string CutHour
		{
			get;
			set;
		}

		[XmlElement("cut_min")]
		public string CutMin
		{
			get;
			set;
		}

		[XmlElement("cut_sec")]
		public string CutSec
		{
			get;
			set;
		}

		[XmlElement("has_recon_conf")]
		public string HasReconConf
		{
			get;
			set;
		}

		[XmlElement("no_conf_reason")]
		public string NoConfReason
		{
			get;
			set;
		}

		[XmlElement("recon_time")]
		public string ReconTime
		{
			get;
			set;
		}

		[XmlElement("refund_rule")]
		public string RefundRule
		{
			get;
			set;
		}
	}
}
