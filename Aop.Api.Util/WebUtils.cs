using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Aop.Api.Util
{
	public sealed class WebUtils
	{
		private int _timeout = 100000;

		public int Timeout
		{
			get
			{
				return _timeout;
			}
			set
			{
				_timeout = value;
			}
		}

		public string DoPost(string url, IDictionary<string, string> parameters, string charset)
		{
			HttpWebRequest webRequest = GetWebRequest(url, "POST");
			webRequest.ContentType = "application/x-www-form-urlencoded;charset=" + charset;
			byte[] bytes = Encoding.GetEncoding(charset).GetBytes(BuildQuery(parameters, charset));
			Stream requestStream = webRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			Encoding encoding = Encoding.GetEncoding(httpWebResponse.CharacterSet);
			return GetResponseAsString(httpWebResponse, encoding);
		}

		public string DoGet(string url, IDictionary<string, string> parameters, string charset)
		{
			if (parameters != null && parameters.Count > 0)
			{
				url = ((!url.Contains("?")) ? (url + "?" + BuildQuery(parameters, charset)) : (url + "&" + BuildQuery(parameters, charset)));
			}
			HttpWebRequest webRequest = GetWebRequest(url, "GET");
			webRequest.ContentType = "application/x-www-form-urlencoded;charset=" + charset;
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			Encoding encoding = Encoding.GetEncoding(httpWebResponse.CharacterSet);
			return GetResponseAsString(httpWebResponse, encoding);
		}

		public string DoPost(string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams, string charset)
		{
			if (fileParams == null || fileParams.Count == 0)
			{
				return DoPost(url, textParams, charset);
			}
			string text = DateTime.Now.Ticks.ToString("X");
			HttpWebRequest webRequest = GetWebRequest(url, "POST");
			webRequest.ContentType = "multipart/form-data;charset=" + charset + ";boundary=" + text;
			Stream requestStream = webRequest.GetRequestStream();
			byte[] bytes = Encoding.GetEncoding(charset).GetBytes("\r\n--" + text + "\r\n");
			byte[] bytes2 = Encoding.GetEncoding(charset).GetBytes("\r\n--" + text + "--\r\n");
			string format = "Content-Disposition:form-data;name=\"{0}\"\r\nContent-Type:text/plain\r\n\r\n{1}";
			IEnumerator<KeyValuePair<string, string>> enumerator = textParams.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string s = string.Format(format, enumerator.Current.Key, enumerator.Current.Value);
				byte[] bytes3 = Encoding.GetEncoding(charset).GetBytes(s);
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Write(bytes3, 0, bytes3.Length);
			}
			string format2 = "Content-Disposition:form-data;name=\"{0}\";filename=\"{1}\"\r\nContent-Type:{2}\r\n\r\n";
			IEnumerator<KeyValuePair<string, FileItem>> enumerator2 = fileParams.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				string key = enumerator2.Current.Key;
				FileItem value = enumerator2.Current.Value;
				string s2 = string.Format(format2, key, value.GetFileName(), value.GetMimeType());
				byte[] bytes4 = Encoding.GetEncoding(charset).GetBytes(s2);
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Write(bytes4, 0, bytes4.Length);
				byte[] content = value.GetContent();
				requestStream.Write(content, 0, content.Length);
			}
			requestStream.Write(bytes2, 0, bytes2.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			Encoding encoding = Encoding.GetEncoding(httpWebResponse.CharacterSet);
			return GetResponseAsString(httpWebResponse, encoding);
		}

		public HttpWebRequest GetWebRequest(string url, string method)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.ServicePoint.Expect100Continue = false;
			httpWebRequest.Method = method;
			httpWebRequest.KeepAlive = true;
			httpWebRequest.UserAgent = "Aop4Net";
			httpWebRequest.Timeout = _timeout;
			return httpWebRequest;
		}

		public string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Stream stream = null;
			StreamReader streamReader = null;
			try
			{
				stream = rsp.GetResponseStream();
				streamReader = new StreamReader(stream, encoding);
				int num = -1;
				while ((num = streamReader.Read()) > -1)
				{
					char c = (char)num;
					if (c != 0)
					{
						stringBuilder.Append(c);
					}
				}
			}
			finally
			{
				streamReader?.Close();
				stream?.Close();
				rsp?.Close();
			}
			return stringBuilder.ToString();
		}

		public static string BuildQuery(IDictionary<string, string> parameters, string charset)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			IEnumerator<KeyValuePair<string, string>> enumerator = parameters.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string key = enumerator.Current.Key;
				string value = enumerator.Current.Value;
				if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
				{
					if (flag)
					{
						stringBuilder.Append("&");
					}
					stringBuilder.Append(key);
					stringBuilder.Append("=");
					string value2 = HttpUtility.UrlEncode(value, Encoding.GetEncoding(charset));
					stringBuilder.Append(value2);
					flag = true;
				}
			}
			return stringBuilder.ToString();
		}
	}
}
