using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiQualityTestCloudacptActivityQueryModel : AopObject
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}

		[XmlElement("uid")]
		public string Uid
		{
			get;
			set;
		}
	}
}
