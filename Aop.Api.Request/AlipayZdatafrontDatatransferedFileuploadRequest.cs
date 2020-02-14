using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayZdatafrontDatatransferedFileuploadRequest : IAopUploadRequest<AlipayZdatafrontDatatransferedFileuploadResponse>, IAopRequest<AlipayZdatafrontDatatransferedFileuploadResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string Columns
		{
			get;
			set;
		}

		public FileItem File
		{
			get;
			set;
		}

		public string FileDescription
		{
			get;
			set;
		}

		public string FileDigest
		{
			get;
			set;
		}

		public string FileType
		{
			get;
			set;
		}

		public string PrimaryKey
		{
			get;
			set;
		}

		public long? Records
		{
			get;
			set;
		}

		public string TypeId
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
			return "alipay.zdatafront.datatransfered.fileupload";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("columns", Columns);
			aopDictionary.Add("file_description", FileDescription);
			aopDictionary.Add("file_digest", FileDigest);
			aopDictionary.Add("file_type", FileType);
			aopDictionary.Add("primary_key", PrimaryKey);
			aopDictionary.Add("records", Records);
			aopDictionary.Add("type_id", TypeId);
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
			dictionary.Add("file", File);
			return dictionary;
		}
	}
}
