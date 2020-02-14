using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DxVerifyResultItem : AopObject
	{
		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("input")]
		public string Input
		{
			get;
			set;
		}

		[XmlElement("line")]
		public long Line
		{
			get;
			set;
		}

		[XmlElement("output")]
		public string Output
		{
			get;
			set;
		}

		[XmlElement("predict")]
		public string Predict
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

		[XmlElement("trace")]
		public string Trace
		{
			get;
			set;
		}
	}
}
