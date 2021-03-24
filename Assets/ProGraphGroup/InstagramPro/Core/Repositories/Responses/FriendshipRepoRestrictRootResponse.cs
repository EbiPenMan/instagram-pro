using System.Collections.Generic;

namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class FriendshipRepoRestrictRootResponse
    {
        private IList<FriendshipRepoRestrictResponseUsersItem> users;
        private string status;

        public FriendshipRepoRestrictRootResponse(in IList<FriendshipRepoRestrictResponseUsersItem> users,
            in string status)
        {
            this.users = users;
            this.status = status;
        }

        public virtual IList<FriendshipRepoRestrictResponseUsersItem> Users
        {
            get { return users; }
        }

        public virtual string Status
        {
            get { return status; }
        }

        public override string ToString()
        {
            return "FriendshipRepoRestrictRootResponse{" + "users=" + users + ", status='" + status + '\'' + '}';
        }
    }
}