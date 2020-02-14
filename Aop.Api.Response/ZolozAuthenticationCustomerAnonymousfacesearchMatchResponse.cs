using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozAuthenticationCustomerAnonymousfacesearchMatchResponse : AopResponse
	{
		[XmlArray("candidatelist")]
		[XmlArrayItem("face_search_user_info")]
		public List<FaceSearchUserInfo> Candidatelist
		{
			get;
			set;
		}

		[XmlElement("foundface")]
		public FaceSearchUserInfo Foundface
		{
			get;
			set;
		}

		[XmlElement("retcodesub")]
		public string Retcodesub
		{
			get;
			set;
		}

		[XmlElement("retmessagesub")]
		public string Retmessagesub
		{
			get;
			set;
		}

		[XmlArray("userinfolist")]
		[XmlArrayItem("face_search_anonymous_user_info")]
		public List<FaceSearchAnonymousUserInfo> Userinfolist
		{
			get;
			set;
		}
	}
}
