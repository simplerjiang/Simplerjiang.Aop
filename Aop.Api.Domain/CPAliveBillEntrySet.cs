using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CPAliveBillEntrySet : AopObject
	{
		[XmlElement("bill_entry_id")]
		public string BillEntryId
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
	}
}
