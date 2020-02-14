using Aop.Api.Response;
using Aop.Api.Util;
using System.Collections.Generic;

namespace Aop.Api.Request
{
	public class AlipayOpenPublicLifeMsgSendRequest : IAopUploadRequest<AlipayOpenPublicLifeMsgSendResponse>, IAopRequest<AlipayOpenPublicLifeMsgSendResponse>
	{
		private bool needEncrypt = false;

		private string apiVersion = "1.0";

		private string terminalType;

		private string terminalInfo;

		private string prodCode;

		private string notifyUrl;

		private string returnUrl;

		private AopObject bizModel;

		public string Category
		{
			get;
			set;
		}

		public string Content
		{
			get;
			set;
		}

		public FileItem Cover
		{
			get;
			set;
		}

		public string Desc
		{
			get;
			set;
		}

		public string MsgType
		{
			get;
			set;
		}

		public string SourceExtInfo
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public string UniqueMsgId
		{
			get;
			set;
		}

		public string VideoLength
		{
			get;
			set;
		}

		public List<string> VideoSamples
		{
			get;
			set;
		}

		public string VideoSize
		{
			get;
			set;
		}

		public string VideoSource
		{
			get;
			set;
		}

		public string VideoTemporaryUrl
		{
			get;
			set;
		}

		public string VideoUrl
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
			return "alipay.open.public.life.msg.send";
		}

		public IDictionary<string, string> GetParameters()
		{
			AopDictionary aopDictionary = new AopDictionary();
			aopDictionary.Add("category", Category);
			aopDictionary.Add("content", Content);
			aopDictionary.Add("desc", Desc);
			aopDictionary.Add("msg_type", MsgType);
			aopDictionary.Add("source_ext_info", SourceExtInfo);
			aopDictionary.Add("title", Title);
			aopDictionary.Add("unique_msg_id", UniqueMsgId);
			aopDictionary.Add("video_length", VideoLength);
			aopDictionary.Add("video_samples", VideoSamples);
			aopDictionary.Add("video_size", VideoSize);
			aopDictionary.Add("video_source", VideoSource);
			aopDictionary.Add("video_temporary_url", VideoTemporaryUrl);
			aopDictionary.Add("video_url", VideoUrl);
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
			dictionary.Add("cover", Cover);
			return dictionary;
		}
	}
}
