using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Datas : AopObject
	{
		[XmlArray("data")]
		[XmlArrayItem("data_entry")]
		public List<DataEntry> Data
		{
			get;
			set;
		}

		[XmlArray("dimension")]
		[XmlArrayItem("data_dim")]
		public List<DataDim> Dimension
		{
			get;
			set;
		}
	}
}
