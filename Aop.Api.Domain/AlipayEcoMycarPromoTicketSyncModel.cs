using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarPromoTicketSyncModel : AopObject
	{
		[XmlElement("active_id")]
		public string ActiveId
		{
			get;
			set;
		}

		[XmlArray("code_no_list")]
		[XmlArrayItem("code_n_o_list")]
		public List<CodeNOList> CodeNoList
		{
			get;
			set;
		}

		[XmlElement("source_type")]
		public string SourceType
		{
			get;
			set;
		}
	}
}
