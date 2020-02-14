using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniInnerversionUploadstatusQueryModel : AopObject
	{
		[XmlElement("build_package_id")]
		public string BuildPackageId
		{
			get;
			set;
		}

		[XmlElement("build_version")]
		public string BuildVersion
		{
			get;
			set;
		}

		[XmlElement("mini_app_id")]
		public string MiniAppId
		{
			get;
			set;
		}
	}
}
