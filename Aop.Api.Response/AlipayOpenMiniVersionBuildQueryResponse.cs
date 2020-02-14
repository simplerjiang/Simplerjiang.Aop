using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniVersionBuildQueryResponse : AopResponse
	{
		[XmlElement("build_status")]
		public string BuildStatus
		{
			get;
			set;
		}

		[XmlElement("create_status")]
		public string CreateStatus
		{
			get;
			set;
		}

		[XmlElement("need_rotation")]
		public string NeedRotation
		{
			get;
			set;
		}

		[XmlElement("version_created")]
		public string VersionCreated
		{
			get;
			set;
		}
	}
}
