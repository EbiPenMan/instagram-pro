namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class FriendshipRepoChangeRootResponse
    {
        private FriendshipRepoChangeResponseFriendshipStatus friendshipStatus;
        private string status;

        public FriendshipRepoChangeRootResponse(in FriendshipRepoChangeResponseFriendshipStatus friendshipStatus, in string status)
        {
            this.friendshipStatus = friendshipStatus;
            this.status = status;
        }

        public virtual FriendshipRepoChangeResponseFriendshipStatus FriendshipStatus
        {
            get
            {
                return friendshipStatus;
            }
        }

        public virtual string Status
        {
            get
            {
                return status;
            }
        }

        public override string ToString()
        {
            return "FriendshipRepositoryChangeResponseRootObject{" + "friendshipStatus=" + friendshipStatus + ", status='" + status + '\'' + '}';
        }
    }
}