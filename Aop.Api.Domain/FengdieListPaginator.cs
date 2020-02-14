using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieListPaginator : AopObject
	{
		[XmlElement("page_count")]
		public long PageCount
		{
			get;
			set;
		}

		[XmlElement("page_number")]
		public long PageNumber
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("total")]
		public long Total
		{
			get;
			set;
		}
	}
}
