using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArrangementBaseSelector : AopObject
	{
		[XmlArray("ar_statuses")]
		[XmlArrayItem("string")]
		public List<string> ArStatuses
		{
			get;
			set;
		}

		[XmlElement("mark_type")]
		public string MarkType
		{
			get;
			set;
		}

		[XmlArray("pd_codes")]
		[XmlArrayItem("string")]
		public List<string> PdCodes
		{
			get;
			set;
		}

		[XmlArray("pd_marks")]
		[XmlArrayItem("string")]
		public List<string> PdMarks
		{
			get;
			set;
		}

		[XmlElement("select_pd_mark")]
		public bool SelectPdMark
		{
			get;
			set;
		}

		[XmlElement("select_pd_name")]
		public bool SelectPdName
		{
			get;
			set;
		}
	}
}
