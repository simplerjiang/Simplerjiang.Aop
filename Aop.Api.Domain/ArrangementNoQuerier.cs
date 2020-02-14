using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArrangementNoQuerier : AopObject
	{
		[XmlArray("ar_nos")]
		[XmlArrayItem("string")]
		public List<string> ArNos
		{
			get;
			set;
		}
	}
}
