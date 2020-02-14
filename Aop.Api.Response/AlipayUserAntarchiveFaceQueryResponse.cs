using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAntarchiveFaceQueryResponse : AopResponse
	{
		[XmlArray("archive_face_list")]
		[XmlArrayItem("archive_face_info")]
		public List<ArchiveFaceInfo> ArchiveFaceList
		{
			get;
			set;
		}
	}
}
