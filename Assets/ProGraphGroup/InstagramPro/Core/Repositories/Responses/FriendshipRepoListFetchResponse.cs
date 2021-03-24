using System.Collections.Generic;
using ProGraphGroup.InstagramPro.Core.Model;
using ProGraphGroup.Utility;

namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class FriendshipRepoListFetchResponse
    {
        private string nextMaxId;
        private string status;
        private IList<FollowModel> items;

        public FriendshipRepoListFetchResponse(in string nextMaxId, in string status, in IList<FollowModel> items)
        {
            this.nextMaxId = nextMaxId;
            this.status = status;
            this.items = items;
        }

        public virtual bool MoreAvailable
        {
            get { return !TextUtils.isEmpty(nextMaxId); }
        }

        public virtual string NextMaxId
        {
            get { return nextMaxId; }
        }

        public virtual FriendshipRepoListFetchResponse setNextMaxId(in string nextMaxId)
        {
            this.nextMaxId = nextMaxId;
            return this;
        }

        public virtual string Status
        {
            get { return status; }
        }

        public virtual FriendshipRepoListFetchResponse setStatus(in string status)
        {
            this.status = status;
            return this;
        }

        public virtual IList<FollowModel> Items
        {
            get { return items; }
        }

        public virtual FriendshipRepoListFetchResponse setItems(in IList<FollowModel> items)
        {
            this.items = items;
            return this;
        }

        public override bool Equals(object o)
        {
            if (this == o)
            {
                return true;
            }

            if (o == null || this.GetType() != o.GetType())
            {
                return false;
            }

            FriendshipRepoListFetchResponse that = (FriendshipRepoListFetchResponse) o;
            return nextMaxId.Equals(that.nextMaxId) && status.Equals(that.status) && items.Equals(that.items);
        }

        public override int GetHashCode()
        {
            return nextMaxId.GetHashCode() ^ status.GetHashCode() ^ items.GetHashCode();
        }

        public override string ToString()
        {
            return "FriendshipRepoListFetchResponse{" + "nextMaxId='" + nextMaxId + '\'' + ", status='" + status +
                   '\'' + ", items=" + items + '}';
        }
    }
}