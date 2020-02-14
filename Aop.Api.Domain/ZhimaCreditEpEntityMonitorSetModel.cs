using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditEpEntityMonitorSetModel : AopObject
	{
		[XmlElement("contact_list")]
		public string ContactList
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
	}
}
