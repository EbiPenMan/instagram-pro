

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class UserInfo
    {
        private readonly string _pk;
        private readonly string _username;
        private readonly string _fullName;
        private readonly string _profilePicUrl;
        private readonly string _hdProfilePicUrl;

        public UserInfo(string pk, string username, string fullName, string profilePicUrl, string hdProfilePicUrl)
        {
            this._pk = pk;
            this._username = username;
            this._fullName = fullName;
            this._profilePicUrl = profilePicUrl;
            this._hdProfilePicUrl = hdProfilePicUrl;
        }

        public string Pk => _pk;

        public string Username => _username;

        public string FullName => _fullName;

        public string ProfilePicUrl => _profilePicUrl;

        public string HdProfilePicUrl => _hdProfilePicUrl;

        public override string ToString()
        {
            return "UserInfo{" +
                   "uid='" + _pk + '\'' +
                   ", username='" + _username + '\'' +
                   ", fullName='" + _fullName + '\'' +
                   ", profilePicUrl='" + _profilePicUrl + '\'' +
                   ", hdProfilePicUrl='" + _hdProfilePicUrl + '\'' +
                   '}';
        }
    }
}
