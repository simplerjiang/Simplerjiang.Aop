using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AiOcrTableRow : AopObject
	{
		[XmlArray("row")]
		[XmlArrayItem("ai_ocr_table_context")]
		public List<AiOcrTableContext> Row
		{
			get;
			set;
		}
	}
}
