using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayInsDataDsbImageUploadRequest : IAopUploadRequest<AlipayInsDataDsbImageUploadResponse>, IAopRequest<AlipayInsDataDsbImageUploadResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string EstimateNo
		{
			get;
			set;
		}

		public string FrameNo
		{
			get;
			set;
		}

		public FileItem ImageContent
		{
			get;
			set;
		}

		public string ImageFormat
		{
			get;
			set;
		}

		public string ImageName
		{
			get;
			set;
		}

		public string ImagePath
		{
			get;
			set;
		}

		public string ImageProperties
		{
			get;
			set;
		}

		public string ImageSource
		{
			get;
			set;
		}

		public string ImageStoreType
		{
			get;
			set;
		}

		public string ImageType
		{
			get;
			set;
		}

		public string LicenseNo
		{
			get;
			set;
		}

		public string ReportNo
		{
			get;
			set;
		}

		public string ShootTime
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
			return "alipay.ins.data.dsb.image.upload";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("estimate_no", EstimateNo);
			aopDictionary.Add("frame_no", FrameNo);
			aopDictionary.Add("image_format", ImageFormat);
			aopDictionary.Add("image_name", ImageName);
			aopDictionary.Add("image_path", ImagePath);
			aopDictionary.Add("image_properties", ImageProperties);
			aopDictionary.Add("image_source", ImageSource);
			aopDictionary.Add("image_store_type", ImageStoreType);
			aopDictionary.Add("image_type", ImageType);
			aopDictionary.Add("license_no", LicenseNo);
			aopDictionary.Add("report_no", ReportNo);
			aopDictionary.Add("shoot_time", ShootTime);
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
			dictionary.Add("image_content", ImageContent);
			return dictionary;
		}
	}
}
