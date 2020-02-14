using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaRiskDetail : AopObject
	{
		[XmlElement("data_type")]
		public string DataType
		{
			get;
			set;
		}

		[XmlElement("extendinfo")]
		public string Extendinfo
		{
			get;
			set;
		}

		[XmlElement("risk_code")]
		public string RiskCode
		{
			get;
			set;
		}

		[XmlElement("risk_type")]
		public string RiskType
		{
			get;
			set;
		}

		[XmlElement("settlement")]
		public string Settlement
		{
			get;
			set;
		}

		[XmlElement("statement")]
		public string Statement
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}

		[XmlElement("update")]
		public string Update
		{
			get;
			set;
		}
	}
}
