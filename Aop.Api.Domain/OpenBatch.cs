using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenBatch : AopObject
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}

		[XmlElement("batch_status")]
		public string BatchStatus
		{
			get;
			set;
		}

		[XmlElement("item_num")]
		public string ItemNum
		{
			get;
			set;
		}
	}
}
