using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MachineInfo : AopObject
	{
		[XmlElement("machine_count")]
		public long MachineCount
		{
			get;
			set;
		}

		[XmlElement("machine_model")]
		public string MachineModel
		{
			get;
			set;
		}

		[XmlElement("machine_type")]
		public string MachineType
		{
			get;
			set;
		}
	}
}
