using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace rchrdKOLLAR.API.GitHub.Model
{
    [DataContract]
    public class GithubUser
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Node_Id { get; set; }

        [DataMember]
        public string Avatar_Url { get; set; }

        [DataMember]
        public string Gravatar_Id { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public string Html_Url { get; set; }

        [DataMember]
        public string Followers_Url { get; set; }

        [DataMember]
        public string Following_Url { get; set; } = null;

        [DataMember]
        public string Subscribtions_Url { get; set; }

        [DataMember]
        public string Organizations_Url { get; set; }

        [DataMember]
        public string Repos_Url { get; set; }

        [DataMember]
        public string Received_Events_Url { get; set; }

        [DataMember]
        public UserType Type { get; set; }

        [DataMember]
        public string Starred_Url { get; set; } = null;

        [DataMember]
        public string Events_Url { get; set; } = null;

        [DataMember]
        public string Site_Admin { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Company { get; set; }

        [DataMember]
        public string Blog { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public bool Hireable { get; set; }

        [DataMember]
        public string Bio { get; set; }

        [DataMember]
        public int Public_Repos { get; set; }

        [DataMember]
        public int Public_Gits { get; set; }

        [DataMember]
        public int Followers { get; set; }

        [DataMember]
        public int Following { get; set; }

        [DataMember]
        public DateTime Created_At { get; set; }

        // this will interest me in particular
        [DataMember]
        public DateTime Updated_At { get; set; }

        [DataMember]
        public string GitsUrl { get; set; } = null;
    }

    public enum UserType
    {
        User,
        Admin
    }

}
