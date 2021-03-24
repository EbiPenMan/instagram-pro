namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class FriendshipRepoRestrictResponseUsersItem
    {
        private long pk;
        private string username;
        private string fullName;
        private bool isPrivate;
        private string profilePicUrl;
        private FriendshipRepoRestrictResponseFriendshipStatus friendshipStatus;
        private bool isVerified;

        public FriendshipRepoRestrictResponseUsersItem(in long pk, in string username, in string fullName,
            in bool isPrivate, in string profilePicUrl,
            in FriendshipRepoRestrictResponseFriendshipStatus friendshipStatus, in bool isVerified)
        {
            this.pk = pk;
            this.username = username;
            this.fullName = fullName;
            this.isPrivate = isPrivate;
            this.profilePicUrl = profilePicUrl;
            this.friendshipStatus = friendshipStatus;
            this.isVerified = isVerified;
        }

        public virtual long Pk
        {
            get { return pk; }
        }

        public virtual string Username
        {
            get { return username; }
        }

        public virtual string FullName
        {
            get { return fullName; }
        }

        public virtual bool Private
        {
            get { return isPrivate; }
        }

        public virtual string ProfilePicUrl
        {
            get { return profilePicUrl; }
        }

        public virtual FriendshipRepoRestrictResponseFriendshipStatus FriendshipStatus
        {
            get { return friendshipStatus; }
        }

        public virtual bool Verified
        {
            get { return isVerified; }
        }


        public override string ToString()
        {
            return "FriendshipRepoRestrictResponseUsersItem{" + "pk=" + pk + ", username='" + username + '\'' +
                   ", fullName='" + fullName + '\'' + ", isPrivate=" + isPrivate + ", profilePicUrl='" + profilePicUrl +
                   '\'' + ", friendshipStatus=" + friendshipStatus + ", isVerified=" + isVerified + '}';
        }
    }
}