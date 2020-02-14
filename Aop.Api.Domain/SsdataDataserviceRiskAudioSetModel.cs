using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataDataserviceRiskAudioSetModel : AopObject
	{
		[XmlElement("creator")]
		public string Creator
		{
			get;
			set;
		}

		[XmlArray("id_list")]
		[XmlArrayItem("string")]
		public List<string> IdList
		{
			get;
			set;
		}

		[XmlArray("keyword_list")]
		[XmlArrayItem("string")]
		public List<string> KeywordList
		{
			get;
			set;
		}

		[XmlElement("modifier")]
		public string Modifier
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public string PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
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
	}
}
