using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Util;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aop.Api.Test
{
	internal class PublicTest
	{
		[STAThread]
		private static void Main()
		{
			IAopClient aopClient = new DefaultAopClient("https://openapi.alipay.com/gateway.do", "app_id", "merchant_private_key", "json", "1.0", "RSA2", "alipay_public_key", "GBK", keyFromFile: false);
			AlipayUserInviteOfflinedetailQueryRequest alipayUserInviteOfflinedetailQueryRequest = new AlipayUserInviteOfflinedetailQueryRequest();
			alipayUserInviteOfflinedetailQueryRequest.BizContent = "{\"pid\":\"2088811331577482\",\"report_date\":\"20181212\",\"partner_id\":\"m_qvdao1_qvdao2\",\"page\":1,\"page_size\":200  }";
			AlipayUserInviteOfflinedetailQueryResponse alipayUserInviteOfflinedetailQueryResponse = aopClient.Execute(alipayUserInviteOfflinedetailQueryRequest);
			Console.WriteLine(alipayUserInviteOfflinedetailQueryResponse.Body);
		}

		private static void CheckSign()
		{
			IDictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("appId", "2013092500031084");
			string privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
			string value = AlipaySignature.RSASign(dictionary, privateKeyPem, null, "RSA");
			dictionary.Add("sign", value);
			string publicKeyPem = GetCurrentPath() + "public-key.pem";
			bool flag = AlipaySignature.RSACheckV2(dictionary, publicKeyPem);
			Console.Write("---------公众号通知消息签名验证--------\n\r");
			Console.Write("checkSign:" + flag.ToString() + "\n\r");
		}

		private static void MenuGet()
		{
			IAopClient alipayClient = GetAlipayClient();
			Console.Write("-------------公众号菜单查询-------------\n\r");
		}

		private static IAopClient GetAlipayClient()
		{
			string serverUrl = "http://openapi.alipaydev.com/gateway.do";
			string appId = "2013092500031084";
			string privateKeyPem = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
			return new DefaultAopClient(serverUrl, appId, privateKeyPem);
		}

		private static string GetCurrentPath()
		{
			string fullName = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
			return fullName + "/Test/";
		}

		public static void CheckSignAndDecrypt()
		{
			string text = "UTF-8";
			string content = "<XML><AppId><![CDATA[2013082200024893]]></AppId><FromUserId><![CDATA[2088102122485786]]></FromUserId><CreateTime>1377228401913</CreateTime><MsgType><![CDATA[click]]></MsgType><EventType><![CDATA[event]]></EventType><ActionParam><![CDATA[authentication]]></ActionParam><AgreementId><![CDATA[201308220000000994]]></AgreementId><AccountNo><![CDATA[null]]></AccountNo><UserInfo><![CDATA[{\"logon_id\":\"15858179811\",\"user_name\":\"许旦辉\"}]]></UserInfo></XML>";
			string text2 = GetCurrentPath() + "public-key.pem";
			string text3 = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
			IDictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("biz_content", AlipaySignature.RSAEncrypt(content, text2, text));
			dictionary.Add("charset", text);
			dictionary.Add("service", "alipay.mobile.public.message.notify");
			dictionary.Add("sign_type", "RSA");
			dictionary.Add("sign", AlipaySignature.RSASign(dictionary, text3, null, "RSA"));
			string str = AlipaySignature.CheckSignAndDecrypt(dictionary, text2, text3, isCheckSign: true, isDecrypt: true);
			Console.Write("resultContent=" + str + "\n\r");
		}

		public static void EncryptAndSign()
		{
			string bizContent = "<XML><ToUserId><![CDATA[2088102122494786]]></ToUserId><AppId><![CDATA[2013111100036093]]></AppId><AgreementId><![CDATA[20131111000001895078]]></AgreementId><CreateTime>12334349884</CreateTime><MsgType><![CDATA[image-text]]></MsgType><ArticleCount>1</ArticleCount><Articles><Item><Title><![CDATA[[回复测试加密解密]]></Title><Desc><![CDATA[测试加密解密]]></Desc><Url><![CDATA[http://m.taobao.com]]></Url><ActionName><![CDATA[立即前往]]></ActionName></Item></Articles><Push><![CDATA[false]]></Push></XML>";
			string alipayPublicKey = GetCurrentPath() + "public-key.pem";
			string cusPrivateKey = GetCurrentPath() + "aop-sandbox-RSA-private-c#.pem";
			string str = AlipaySignature.encryptAndSign(bizContent, alipayPublicKey, cusPrivateKey, "UTF-8", isEncrypt: true, isSign: true);
			Console.Write("resultContent=" + str + "\n\r");
		}
	}
}
