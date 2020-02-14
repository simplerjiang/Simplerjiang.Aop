using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySocialBaseRelationFriendsQueryResponse : AopResponse
	{
		[XmlArray("friend_list")]
		[XmlArrayItem("friend_list_v_o")]
		public List<FriendListVO> FriendList
		{
			get;
			set;
		}
	}
}
