using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TravelScene : AopObject
	{
		[XmlArray("data_list")]
		[XmlArrayItem("travel_mall_request")]
		public List<TravelMallRequest> DataList
		{
			get;
			set;
		}
	}
}
