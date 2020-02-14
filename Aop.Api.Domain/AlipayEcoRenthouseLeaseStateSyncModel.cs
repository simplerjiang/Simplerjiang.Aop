using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseLeaseStateSyncModel : AopObject
	{
		[XmlElement("lease_ca_file")]
		public string LeaseCaFile
		{
			get;
			set;
		}

		[XmlElement("lease_code")]
		public string LeaseCode
		{
			get;
			set;
		}

		[XmlElement("lease_status")]
		public long LeaseStatus
		{
			get;
			set;
		}
	}
}
