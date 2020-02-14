using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditEpEntityMonitorUploadModel : AopObject
	{
		[XmlElement("entity_list")]
		public string EntityList
		{
			get;
			set;
		}

		[XmlElement("entity_type")]
		public string EntityType
		{
			get;
			set;
		}

		[XmlElement("solution_id")]
		public string SolutionId
		{
			get;
			set;
		}

		[XmlElement("zhima_pid")]
		public string ZhimaPid
		{
			get;
			set;
		}
	}
}
