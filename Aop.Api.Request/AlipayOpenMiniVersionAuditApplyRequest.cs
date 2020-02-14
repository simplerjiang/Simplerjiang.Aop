using Aop.Api.Domain;
using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayOpenMiniVersionAuditApplyRequest : IAopUploadRequest<AlipayOpenMiniVersionAuditApplyResponse>, IAopRequest<AlipayOpenMiniVersionAuditApplyResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string AppCategoryIds
		{
			get;
			set;
		}

		public string AppDesc
		{
			get;
			set;
		}

		public string AppEnglishName
		{
			get;
			set;
		}

		public FileItem AppLogo
		{
			get;
			set;
		}

		public string AppName
		{
			get;
			set;
		}

		public string AppSlogan
		{
			get;
			set;
		}

		public string AppVersion
		{
			get;
			set;
		}

		public FileItem FifthLicensePic
		{
			get;
			set;
		}

		public FileItem FifthScreenShot
		{
			get;
			set;
		}

		public FileItem FirstLicensePic
		{
			get;
			set;
		}

		public FileItem FirstScreenShot
		{
			get;
			set;
		}

		public FileItem FourthLicensePic
		{
			get;
			set;
		}

		public FileItem FourthScreenShot
		{
			get;
			set;
		}

		public string LicenseName
		{
			get;
			set;
		}

		public string LicenseNo
		{
			get;
			set;
		}

		public string LicenseValidDate
		{
			get;
			set;
		}

		public string Memo
		{
			get;
			set;
		}

		public FileItem OutDoorPic
		{
			get;
			set;
		}

		public string RegionType
		{
			get;
			set;
		}

		public FileItem SecondLicensePic
		{
			get;
			set;
		}

		public FileItem SecondScreenShot
		{
			get;
			set;
		}

		public string ServiceEmail
		{
			get;
			set;
		}

		public string ServicePhone
		{
			get;
			set;
		}

		public List<RegionInfo> ServiceRegionInfo
		{
			get;
			set;
		}

		public FileItem ThirdLicensePic
		{
			get;
			set;
		}

		public FileItem ThirdScreenShot
		{
			get;
			set;
		}

		public string VersionDesc
		{
			get;
			set;
		}

		public void SetNeedEncrypt(bool needEncrypt)
		{
			this.needEncrypt = needEncrypt;
		}

		public bool GetNeedEncrypt()
		{
			return needEncrypt;
		}

		public void SetNotifyUrl(string notifyUrl)
		{
			this.notifyUrl = notifyUrl;
		}

		public string GetNotifyUrl()
		{
			return notifyUrl;
		}

		public void SetReturnUrl(string returnUrl)
		{
			this.returnUrl = returnUrl;
		}

		public string GetReturnUrl()
		{
			return returnUrl;
		}

		public void SetTerminalType(string terminalType)
		{
			this.terminalType = terminalType;
		}

		public string GetTerminalType()
		{
			return terminalType;
		}

		public void SetTerminalInfo(string terminalInfo)
		{
			this.terminalInfo = terminalInfo;
		}

		public string GetTerminalInfo()
		{
			return terminalInfo;
		}

		public void SetProdCode(string prodCode)
		{
			this.prodCode = prodCode;
		}

		public string GetProdCode()
		{
			return prodCode;
		}

		public void SetApiVersion(string apiVersion)
		{
			this.apiVersion = apiVersion;
		}

		public string GetApiVersion()
		{
			return apiVersion;
		}

		public string GetApiName()
		{
			return "alipay.open.mini.version.audit.apply";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("app_category_ids", AppCategoryIds);
			aopDictionary.Add("app_desc", AppDesc);
			aopDictionary.Add("app_english_name", AppEnglishName);
			aopDictionary.Add("app_name", AppName);
			aopDictionary.Add("app_slogan", AppSlogan);
			aopDictionary.Add("app_version", AppVersion);
			aopDictionary.Add("license_name", LicenseName);
			aopDictionary.Add("license_no", LicenseNo);
			aopDictionary.Add("license_valid_date", LicenseValidDate);
			aopDictionary.Add("memo", Memo);
			aopDictionary.Add("region_type", RegionType);
			aopDictionary.Add("service_email", ServiceEmail);
			aopDictionary.Add("service_phone", ServicePhone);
			aopDictionary.Add("service_region_info", ServiceRegionInfo);
			aopDictionary.Add("version_desc", VersionDesc);
			return aopDictionary;
		}

		public AopObject GetBizModel()
		{
			return bizModel;
		}

		public void SetBizModel(AopObject bizModel)
		{
			this.bizModel = bizModel;
		}

		public IDictionary<string, FileItem> GetFileParameters()
		{
			IDictionary<string, FileItem> dictionary = new Dictionary<string, FileItem>();
			dictionary.Add("app_logo", AppLogo);
			dictionary.Add("fifth_license_pic", FifthLicensePic);
			dictionary.Add("fifth_screen_shot", FifthScreenShot);
			dictionary.Add("first_license_pic", FirstLicensePic);
			dictionary.Add("first_screen_shot", FirstScreenShot);
			dictionary.Add("fourth_license_pic", FourthLicensePic);
			dictionary.Add("fourth_screen_shot", FourthScreenShot);
			dictionary.Add("out_door_pic", OutDoorPic);
			dictionary.Add("second_license_pic", SecondLicensePic);
			dictionary.Add("second_screen_shot", SecondScreenShot);
			dictionary.Add("third_license_pic", ThirdLicensePic);
			dictionary.Add("third_screen_shot", ThirdScreenShot);
			return dictionary;
		}
	}
}
