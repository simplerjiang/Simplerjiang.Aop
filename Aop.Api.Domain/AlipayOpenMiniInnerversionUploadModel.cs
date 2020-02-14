using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniInnerversionUploadModel : AopObject
	{
		[XmlElement("build_app_type")]
		public string BuildAppType
		{
			get;
			set;
		}

		[XmlElement("build_extra_info")]
		public string BuildExtraInfo
		{
			get;
			set;
		}

		[XmlElement("build_js_permission")]
		public string BuildJsPermission
		{
			get;
			set;
		}

		[XmlElement("build_main_url")]
		public string BuildMainUrl
		{
			get;
			set;
		}

		[XmlElement("build_package_md_5")]
		public string BuildPackageMd5
		{
			get;
			set;
		}

		[XmlElement("build_package_name")]
		public string BuildPackageName
		{
			get;
			set;
		}

		[XmlElement("build_package_stream")]
		public string BuildPackageStream
		{
			get;
			set;
		}

		[XmlElement("build_qcloud_info")]
		public string BuildQcloudInfo
		{
			get;
			set;
		}

		[XmlElement("build_source_pkg_url")]
		public string BuildSourcePkgUrl
		{
			get;
			set;
		}

		[XmlElement("build_sub_url")]
		public string BuildSubUrl
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

		[XmlElement("client_type")]
		public string ClientType
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
