using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniVersionDetailQueryResponse : AopResponse
	{
		[XmlElement("app_desc")]
		public string AppDesc
		{
			get;
			set;
		}

		[XmlElement("app_english_name")]
		public string AppEnglishName
		{
			get;
			set;
		}

		[XmlElement("app_logo")]
		public string AppLogo
		{
			get;
			set;
		}

		[XmlElement("app_name")]
		public string AppName
		{
			get;
			set;
		}

		[XmlElement("app_slogan")]
		public string AppSlogan
		{
			get;
			set;
		}

		[XmlElement("app_version")]
		public string AppVersion
		{
			get;
			set;
		}

		[XmlElement("gmt_apply_audit")]
		public string GmtApplyAudit
		{
			get;
			set;
		}

		[XmlElement("gmt_audit_end")]
		public string GmtAuditEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_offline")]
		public string GmtOffline
		{
			get;
			set;
		}

		[XmlElement("gmt_online")]
		public string GmtOnline
		{
			get;
			set;
		}

		[XmlElement("gray_strategy")]
		public string GrayStrategy
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlArray("mini_app_category_info_list")]
		[XmlArrayItem("mini_app_category_info")]
		public List<MiniAppCategoryInfo> MiniAppCategoryInfoList
		{
			get;
			set;
		}

		[XmlArray("package_info_list")]
		[XmlArrayItem("mini_package_info")]
		public List<MiniPackageInfo> PackageInfoList
		{
			get;
			set;
		}

		[XmlElement("reject_reason")]
		public string RejectReason
		{
			get;
			set;
		}

		[XmlElement("scan_result")]
		public string ScanResult
		{
			get;
			set;
		}

		[XmlArray("screen_shot_list")]
		[XmlArrayItem("string")]
		public List<string> ScreenShotList
		{
			get;
			set;
		}

		[XmlElement("service_email")]
		public string ServiceEmail
		{
			get;
			set;
		}

		[XmlElement("service_phone")]
		public string ServicePhone
		{
			get;
			set;
		}

		[XmlArray("service_region_info")]
		[XmlArrayItem("region_info")]
		public List<RegionInfo> ServiceRegionInfo
		{
			get;
			set;
		}

		[XmlElement("service_region_type")]
		public string ServiceRegionType
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("version_desc")]
		public string VersionDesc
		{
			get;
			set;
		}
	}
}
