using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniInnerversionUploadstatusQueryResponse : AopResponse
	{
		[XmlElement("build_info")]
		public string BuildInfo
		{
			get;
			set;
		}

		[XmlElement("build_package_url")]
		public string BuildPackageUrl
		{
			get;
			set;
		}

		[XmlElement("build_status")]
		public string BuildStatus
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
