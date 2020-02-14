using Aop.Api.Parser;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Util;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Aop.Api
{
	public class AlipayMobilePublicMultiMediaClient : IAopClient
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

		public const string APP_AUTH_TOKEN = "app_auth_token";

		private string version;

		private string format;

		private string serverUrl;

		private string appId;

		private string privateKeyPem;

		private string signType = "RSA";

		private string charset;

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

		public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem)
		{
			this.appId = appId;
			this.privateKeyPem = privateKeyPem;
			this.serverUrl = serverUrl;
			webUtils = new WebUtils();
		}

		public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format)
			: this(serverUrl, appId, privateKeyPem)
		{
			this.format = format;
		}

		public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format, string charset)
			: this(serverUrl, appId, privateKeyPem, format)
		{
			this.charset = charset;
		}

		public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format, string version, string signType)
			: this(serverUrl, appId, privateKeyPem, format)
		{
			this.version = version;
			this.signType = signType;
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

		public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
		{
			AlipayMobilePublicMultiMediaDownloadRequest alipayMobilePublicMultiMediaDownloadRequest = (AlipayMobilePublicMultiMediaDownloadRequest)request;
			AopDictionary aopDictionary = new AopDictionary(request.GetParameters());
			aopDictionary.Add("method", request.GetApiName());
			aopDictionary.Add("version", Version);
			aopDictionary.Add("app_id", appId);
			aopDictionary.Add("format", format);
			aopDictionary.Add("timestamp", DateTime.Now);
			aopDictionary.Add("auth_token", accessToken);
			aopDictionary.Add("sign_type", signType);
			aopDictionary.Add("terminal_type", request.GetTerminalType());
			aopDictionary.Add("terminal_info", request.GetTerminalInfo());
			aopDictionary.Add("prod_code", request.GetProdCode());
			if (!string.IsNullOrEmpty(appAuthToken))
			{
				aopDictionary.Add("app_auth_token", appAuthToken);
			}
			aopDictionary.Add("sign", AopUtils.SignAopRequest(aopDictionary, privateKeyPem, charset, signType));
			Stream stream = alipayMobilePublicMultiMediaDownloadRequest.stream;
			AopResponse aopResponse = DoGet(aopDictionary, stream);
			return (T)aopResponse;
		}

		private AopResponse DoGet(AopDictionary parameters, Stream outStream)
		{
			AlipayMobilePublicMultiMediaDownloadResponse result = null;
			string text = serverUrl;
			Console.WriteLine(text);
			if (parameters != null && parameters.Count > 0)
			{
				text = ((!text.Contains("?")) ? (text + "?" + WebUtils.BuildQuery(parameters, charset)) : (text + "&" + WebUtils.BuildQuery(parameters, charset)));
			}
			HttpWebRequest webRequest = webUtils.GetWebRequest(text, "GET");
			webRequest.ContentType = "application/x-www-form-urlencoded;charset=" + charset;
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				if (httpWebResponse.ContentType.ToLower().Contains("text/plain"))
				{
					Encoding encoding = Encoding.GetEncoding(httpWebResponse.CharacterSet);
					string responseAsString = webUtils.GetResponseAsString(httpWebResponse, encoding);
					IAopParser<AlipayMobilePublicMultiMediaDownloadResponse> aopParser = new AopJsonParser<AlipayMobilePublicMultiMediaDownloadResponse>();
					result = aopParser.Parse(responseAsString, charset);
				}
				else
				{
					GetResponseAsStream(outStream, httpWebResponse);
					result = new AlipayMobilePublicMultiMediaDownloadResponse();
				}
			}
			return result;
		}

		public void GetResponseAsStream(Stream outStream, HttpWebResponse rsp)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Stream stream = null;
			StreamReader streamReader = null;
			BinaryWriter binaryWriter = null;
			try
			{
				stream = rsp.GetResponseStream();
				streamReader = new StreamReader(stream);
				binaryWriter = new BinaryWriter(outStream);
				int num = Convert.ToInt32(rsp.ContentLength);
				byte[] buffer = new byte[num];
				int num2 = 0;
				while ((num2 = stream.Read(buffer, 0, num)) > 0)
				{
					outStream.Write(buffer, 0, num2);
				}
				outStream.Flush();
				outStream.Close();
			}
			finally
			{
				streamReader?.Close();
				stream?.Close();
				rsp?.Close();
			}
		}

		public T pageExecute<T>(IAopRequest<T> request) where T : AopResponse
		{
			throw new NotImplementedException();
		}

		public T pageExecute<T>(IAopRequest<T> request, string session, string reqMethod) where T : AopResponse
		{
			throw new NotImplementedException();
		}

		public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
		{
			throw new NotImplementedException();
		}
	}
}
