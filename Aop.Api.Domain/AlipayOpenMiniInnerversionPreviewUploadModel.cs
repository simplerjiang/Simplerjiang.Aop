using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniInnerversionPreviewUploadModel : AopObject
	{
		[XmlElement("build_js_permission")]
		public string BuildJsPermission
		{
			get;
			set;
		}

		[XmlElement("build_pkg_url")]
		public string BuildPkgUrl
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
