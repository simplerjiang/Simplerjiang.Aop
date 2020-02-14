using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiQualityTestCloudacptActivityQueryResponse : AopResponse
	{
		[XmlArray("activity_list")]
		[XmlArrayItem("open_activity")]
		public List<OpenActivity> ActivityList
		{
			get;
			set;
		}
	}
}
