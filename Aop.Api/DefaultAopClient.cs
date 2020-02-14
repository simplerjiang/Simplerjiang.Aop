using Aop.Api.Parser;
using Aop.Api.Request;
using Aop.Api.Util;
using Jayrock.Json;
using Jayrock.Json.Conversion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Aop.Api
{
	public class DefaultAopClient : IAopClient
	{
		public const string APP_ID = "app_id";

		public const string FORMAT = "format";

		public const string METHOD = "method";

		public const string TIMESTAMP = "timestamp";

		public const string VERSION = "version";

		public const string SIGN_TYPE = "sign_type";

		public const string ACCESS_TOKEN = "auth_token";

		public const string SIGN = "sign";

		public const string TERMINAL_TYPE = "terminal_type";

		public const string TERMINAL_INFO = "terminal_info";

		public const string PROD_CODE = "prod_code";

		public const string NOTIFY_URL = "notify_url";

		public const string CHARSET = "charset";

		public const string ENCRYPT_TYPE = "encrypt_type";

		public const string BIZ_CONTENT = "biz_content";

		public const string APP_AUTH_TOKEN = "app_auth_token";

		public const string RETURN_URL = "return_url";

		private string version;

		private string format;

		private string serverUrl;

		private string appId;

		private string privateKeyPem;

		private string signType = "RSA";

		private string charset;

		private string alipayPublicKey;

		private bool keyFromFile = false;

		private string httpmethod;

		public string return_url;

		public string notify_url;

		private string encyptKey;

		private string encyptType = "AES";

		private WebUtils webUtils;

		public string Version
		{
			get
			{
				return (version != null) ? version : "1.0";
			}
			set
			{
				version = value;
			}
		}

		public string Format
		{
			get
			{
				return (format != null) ? format : "json";
			}
			set
			{
				format = value;
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set
			{
				appId = value;
			}
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem)
		{
			this.appId = appId;
			this.privateKeyPem = privateKeyPem;
			this.serverUrl = serverUrl;
			webUtils = new WebUtils();
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, bool keyFromFile)
		{
			this.appId = appId;
			this.privateKeyPem = privateKeyPem;
			this.serverUrl = serverUrl;
			this.keyFromFile = keyFromFile;
			webUtils = new WebUtils();
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format)
		{
			this.appId = appId;
			this.privateKeyPem = privateKeyPem;
			this.serverUrl = serverUrl;
			this.format = format;
			webUtils = new WebUtils();
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string charset)
			: this(serverUrl, appId, privateKeyPem, format)
		{
			this.charset = charset;
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType)
			: this(serverUrl, appId, privateKeyPem)
		{
			this.format = format;
			this.version = version;
			this.signType = signType;
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey)
			: this(serverUrl, appId, privateKeyPem, format, version, signType)
		{
			alipayPublicKey = alipayPulicKey;
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset)
			: this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
		{
			this.charset = charset;
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset, bool keyFromFile)
			: this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
		{
			this.keyFromFile = keyFromFile;
			this.charset = charset;
		}

		public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType, string alipayPulicKey, string charset, string encyptKey)
			: this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey, charset)
		{
			this.encyptKey = encyptKey;
			encyptType = "AES";
		}

		public void SetTimeout(int timeout)
		{
			webUtils.Timeout = timeout;
		}

		public T Execute<T>(IAopRequest<T> request) where T : AopResponse
		{
			return Execute(request, null);
		}

		public T Execute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
		{
			return Execute(request, accessToken, null);
		}

		public T pageExecute<T>(IAopRequest<T> request) where T : AopResponse
		{
			return pageExecute(request, null, "POST");
		}

		public T pageExecute<T>(IAopRequest<T> request, string accessToken, string reqMethod) where T : AopResponse
		{
			if (string.IsNullOrEmpty(charset))
			{
				charset = "utf-8";
			}
			string text = null;
			text = (string.IsNullOrEmpty(request.GetApiVersion()) ? Version : request.GetApiVersion());
			AopDictionary requestParams = new AopDictionary(request.GetParameters());
			requestParams = SerializeBizModel(requestParams, request);
			StringBuilder stringBuilder = new StringBuilder();
			requestParams.Add("method", request.GetApiName());
			requestParams.Add("version", text);
			requestParams.Add("app_id", appId);
			requestParams.Add("format", format);
			requestParams.Add("timestamp", DateTime.Now);
			requestParams.Add("auth_token", accessToken);
			requestParams.Add("sign_type", signType);
			requestParams.Add("terminal_type", request.GetTerminalType());
			requestParams.Add("terminal_info", request.GetTerminalInfo());
			requestParams.Add("prod_code", request.GetProdCode());
			requestParams.Add("notify_url", request.GetNotifyUrl());
			requestParams.Add("charset", charset);
			requestParams.Add("return_url", request.GetReturnUrl());
			IDictionary<string, string> dictionary = new SortedDictionary<string, string>(requestParams);
			requestParams = new AopDictionary(dictionary);
			requestParams.Add("sign", AopUtils.SignAopRequest(dictionary, privateKeyPem, charset, keyFromFile, signType));
			string body;
			if (request is IAopUploadRequest<T>)
			{
				IAopUploadRequest<T> aopUploadRequest = (IAopUploadRequest<T>)request;
				IDictionary<string, FileItem> fileParams = AopUtils.CleanupDictionary(aopUploadRequest.GetFileParameters());
				body = webUtils.DoPost(serverUrl + "?charset=" + charset, requestParams, fileParams, charset);
			}
			else if (reqMethod.Equals("GET"))
			{
				string text2 = serverUrl;
				if (requestParams != null && requestParams.Count > 0)
				{
					text2 = ((!text2.Contains("?")) ? (text2 + "?" + WebUtils.BuildQuery(requestParams, charset)) : (text2 + "&" + WebUtils.BuildQuery(requestParams, charset)));
				}
				body = text2;
			}
			else
			{
				body = BuildHtmlRequest(requestParams, reqMethod, reqMethod);
			}
			T val = null;
			IAopParser<T> aopParser = null;
			if ("xml".Equals(format))
			{
				aopParser = new AopXmlParser<T>();
				return aopParser.Parse(body, charset);
			}
			aopParser = new AopJsonParser<T>();
			return aopParser.Parse(body, charset);
		}

		public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
		{
			if (string.IsNullOrEmpty(charset))
			{
				charset = "utf-8";
			}
			string text = null;
			text = (string.IsNullOrEmpty(request.GetApiVersion()) ? Version : request.GetApiVersion());
			AopDictionary requestParams = new AopDictionary(request.GetParameters());
			requestParams = SerializeBizModel(requestParams, request);
			requestParams.Add("method", request.GetApiName());
			requestParams.Add("version", text);
			requestParams.Add("app_id", appId);
			requestParams.Add("format", format);
			requestParams.Add("timestamp", DateTime.Now);
			requestParams.Add("auth_token", accessToken);
			requestParams.Add("sign_type", signType);
			requestParams.Add("terminal_type", request.GetTerminalType());
			requestParams.Add("terminal_info", request.GetTerminalInfo());
			requestParams.Add("prod_code", request.GetProdCode());
			requestParams.Add("charset", charset);
			if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
			{
				requestParams.Add("notify_url", request.GetNotifyUrl());
			}
			if (!string.IsNullOrEmpty(appAuthToken))
			{
				requestParams.Add("app_auth_token", appAuthToken);
			}
			if (request.GetNeedEncrypt())
			{
				if (string.IsNullOrEmpty(requestParams["biz_content"]))
				{
					throw new AopException("api request Fail ! The reason: encrypt request is not supported!");
				}
				if (string.IsNullOrEmpty(encyptKey) || string.IsNullOrEmpty(encyptType))
				{
					throw new AopException("encryptType or encryptKey must not null!");
				}
				if (!"AES".Equals(encyptType))
				{
					throw new AopException("api only support Aes!");
				}
				string value = AopUtils.AesEncrypt(encyptKey, requestParams["biz_content"], charset);
				requestParams.Remove("biz_content");
				requestParams.Add("biz_content", value);
				requestParams.Add("encrypt_type", encyptType);
			}
			requestParams.Add("sign", AopUtils.SignAopRequest(requestParams, privateKeyPem, charset, keyFromFile, signType));
			string text2;
			if (request is IAopUploadRequest<T>)
			{
				IAopUploadRequest<T> aopUploadRequest = (IAopUploadRequest<T>)request;
				IDictionary<string, FileItem> fileParams = AopUtils.CleanupDictionary(aopUploadRequest.GetFileParameters());
				text2 = webUtils.DoPost(serverUrl + "?charset=" + charset, requestParams, fileParams, charset);
			}
			else
			{
				text2 = webUtils.DoPost(serverUrl + "?charset=" + charset, requestParams, charset);
			}
			T val = null;
			IAopParser<T> aopParser = null;
			if ("xml".Equals(format))
			{
				aopParser = new AopXmlParser<T>();
				val = aopParser.Parse(text2, charset);
			}
			else
			{
				aopParser = new AopJsonParser<T>();
				val = aopParser.Parse(text2, charset);
			}
			ResponseParseItem responseParseItem = parseRespItem(request, text2, aopParser, encyptKey, encyptType, charset);
			val = aopParser.Parse(responseParseItem.realContent, charset);
			CheckResponseSign(request, responseParseItem.respContent, val.IsError, aopParser, alipayPublicKey, charset, signType, keyFromFile);
			return val;
		}

		private static ResponseParseItem parseRespItem<T>(IAopRequest<T> request, string respBody, IAopParser<T> parser, string encryptKey, string encryptType, string charset) where T : AopResponse
		{
			string text = null;
			text = ((!request.GetNeedEncrypt()) ? respBody : parser.EncryptSourceData(request, respBody, encryptType, encryptKey, charset));
			ResponseParseItem responseParseItem = new ResponseParseItem();
			responseParseItem.realContent = text;
			responseParseItem.respContent = respBody;
			return responseParseItem;
		}

		public static void CheckResponseSign<T>(IAopRequest<T> request, string responseBody, bool isError, IAopParser<T> parser, string alipayPublicKey, string charset, string signType) where T : AopResponse
		{
			if (string.IsNullOrEmpty(alipayPublicKey) || string.IsNullOrEmpty(charset))
			{
				return;
			}
			SignItem signItem = parser.GetSignItem(request, responseBody);
			if (signItem == null)
			{
				throw new AopException("sign check fail: Body is Empty!");
			}
			if ((!isError || (isError && !string.IsNullOrEmpty(signItem.Sign))) && !AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey, charset, signType))
			{
				if (string.IsNullOrEmpty(signItem.SignSourceDate) || !signItem.SignSourceDate.Contains("\\/"))
				{
					throw new AopException("sign check fail: check Sign and Data Fail!");
				}
				string signContent = signItem.SignSourceDate.Replace("\\/", "/");
				if (!AlipaySignature.RSACheckContent(signContent, signItem.Sign, alipayPublicKey, charset, signType))
				{
					throw new AopException("sign check fail: check Sign and Data Fail JSON also");
				}
			}
		}

		public static void CheckResponseSign<T>(IAopRequest<T> request, string responseBody, bool isError, IAopParser<T> parser, string alipayPublicKey, string charset, string signType, bool keyFromFile) where T : AopResponse
		{
			if (string.IsNullOrEmpty(alipayPublicKey) || string.IsNullOrEmpty(charset))
			{
				return;
			}
			SignItem signItem = parser.GetSignItem(request, responseBody);
			if (signItem == null)
			{
				throw new AopException("sign check fail: Body is Empty!");
			}
			if ((!isError || (isError && !string.IsNullOrEmpty(signItem.Sign))) && !AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey, charset, signType, keyFromFile))
			{
				if (string.IsNullOrEmpty(signItem.SignSourceDate) || !signItem.SignSourceDate.Contains("\\/"))
				{
					throw new AopException("sign check fail: check Sign and Data Fail!");
				}
				string signContent = signItem.SignSourceDate.Replace("\\/", "/");
				if (!AlipaySignature.RSACheckContent(signContent, signItem.Sign, alipayPublicKey, charset, signType, keyFromFile))
				{
					throw new AopException("sign check fail: check Sign and Data Fail JSON also");
				}
			}
		}

		public string BuildHtmlRequest(IDictionary<string, string> sParaTemp, string strMethod, string strButtonValue)
		{
			IDictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary = sParaTemp;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<form id='alipaysubmit' name='alipaysubmit' action='" + serverUrl + "?charset=" + charset + "' method='" + strMethod + "' style='display:none;'>");
			foreach (KeyValuePair<string, string> item in dictionary)
			{
				stringBuilder.Append("<input  name='" + item.Key + "' value='" + item.Value + "'/>");
			}
			stringBuilder.Append("<input type='submit' value='" + strButtonValue + "' style='display:none;'></form>");
			stringBuilder.Append("<script>document.forms['alipaysubmit'].submit();</script>");
			return stringBuilder.ToString();
		}

		public Dictionary<string, string> FilterPara(SortedDictionary<string, string> dicArrayPre)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (KeyValuePair<string, string> item in dicArrayPre)
			{
				if (item.Key.ToLower() != "sign" && item.Key.ToLower() != "sign_type" && item.Value != "" && item.Value != null)
				{
					dictionary.Add(item.Key, item.Value);
				}
			}
			return dictionary;
		}

		public static string CreateLinkStringUrlencode(Dictionary<string, string> dicArray, Encoding code)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, string> item in dicArray)
			{
				stringBuilder.Append(item.Key + "=" + HttpUtility.UrlEncode(item.Value, code) + "&");
			}
			int length = stringBuilder.Length;
			stringBuilder.Remove(length - 1, 1);
			return stringBuilder.ToString();
		}

		public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
		{
			AopDictionary dictionary = buildRequestParams(request, null, null);
			IDictionary<string, string> dictionary2 = new SortedDictionary<string, string>(dictionary);
			AopDictionary aopDictionary = new AopDictionary(dictionary2);
			string text = string.IsNullOrEmpty(charset) ? "utf-8" : charset;
			string value = AopUtils.SignAopRequest(aopDictionary, privateKeyPem, text, keyFromFile, signType);
			aopDictionary.Add("sign", value);
			string body = WebUtils.BuildQuery(aopDictionary, text);
			T val = (T)Activator.CreateInstance(typeof(T));
			val.Body = body;
			return val;
		}

		private AopDictionary buildRequestParams<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
		{
			AopDictionary requestParams = new AopDictionary(request.GetParameters());
			AopDictionary aopDictionary = SerializeBizModel(requestParams, request);
			string value = string.IsNullOrEmpty(charset) ? "utf-8" : charset;
			string value2 = string.IsNullOrEmpty(request.GetApiVersion()) ? Version : request.GetApiVersion();
			aopDictionary.Add("method", request.GetApiName());
			aopDictionary.Add("version", value2);
			aopDictionary.Add("app_id", appId);
			aopDictionary.Add("format", format);
			aopDictionary.Add("timestamp", DateTime.Now);
			aopDictionary.Add("auth_token", accessToken);
			aopDictionary.Add("sign_type", signType);
			aopDictionary.Add("terminal_type", request.GetTerminalType());
			aopDictionary.Add("terminal_info", request.GetTerminalInfo());
			aopDictionary.Add("prod_code", request.GetProdCode());
			aopDictionary.Add("notify_url", request.GetNotifyUrl());
			aopDictionary.Add("charset", value);
			aopDictionary.Add("return_url", request.GetReturnUrl());
			aopDictionary.Add("app_auth_token", appAuthToken);
			if (request.GetNeedEncrypt())
			{
				if (string.IsNullOrEmpty(aopDictionary["biz_content"]))
				{
					throw new AopException("api request Fail ! The reason: encrypt request is not supported!");
				}
				if (string.IsNullOrEmpty(encyptKey) || string.IsNullOrEmpty(encyptType))
				{
					throw new AopException("encryptType or encryptKey must not null!");
				}
				if (!"AES".Equals(encyptType))
				{
					throw new AopException("api only support Aes!");
				}
				string value3 = AopUtils.AesEncrypt(encyptKey, aopDictionary["biz_content"], charset);
				aopDictionary.Remove("biz_content");
				aopDictionary.Add("biz_content", value3);
				aopDictionary.Add("encrypt_type", encyptType);
			}
			return aopDictionary;
		}

		private AopDictionary SerializeBizModel<T>(AopDictionary requestParams, IAopRequest<T> request) where T : AopResponse
		{
			if ((!requestParams.ContainsKey("biz_content") || string.IsNullOrEmpty(requestParams["biz_content"])) && request.GetBizModel() != null)
			{
				AopObject bizModel = request.GetBizModel();
				string value = Serialize(bizModel);
				requestParams.Add("biz_content", value);
			}
			return requestParams;
		}

		private string Serialize(AopObject obj)
		{
			AopModelParser aopModelParser = new AopModelParser();
			JsonObject value = aopModelParser.serializeAopObject(obj);
			return JsonConvert.ExportToString(value);
		}
	}
}
