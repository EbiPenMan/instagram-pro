namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class FriendshipRepoChangeResponseFriendshipStatus
    {
        private bool following;
        private bool followedBy;
        private bool blocking;
        private bool muting;
        private bool isPrivate;
        private bool incomingRequest;
        private bool outgoingRequest;
        private bool isBestie;

        public FriendshipRepoChangeResponseFriendshipStatus(in bool following, in bool followedBy, in bool blocking,
            in bool muting, in bool isPrivate, in bool incomingRequest, in bool outgoingRequest, in bool isBestie)
        {
            this.following = following;
            this.followedBy = followedBy;
            this.blocking = blocking;
            this.muting = muting;
            this.isPrivate = isPrivate;
            this.incomingRequest = incomingRequest;
            this.outgoingRequest = outgoingRequest;
            this.isBestie = isBestie;
        }

        public virtual bool Following
        {
            get { return following; }
        }

        public virtual bool FollowedBy
        {
            get { return followedBy; }
        }

        public virtual bool Blocking
        {
            get { return blocking; }
        }

        public virtual bool Muting
        {
            get { return muting; }
        }

        public virtual bool Private
        {
            get { return isPrivate; }
        }

        public virtual bool IncomingRequest
        {
            get { return incomingRequest; }
        }

        public virtual bool OutgoingRequest
        {
            get { return outgoingRequest; }
        }

        public virtual bool Bestie
        {
            get { return isBestie; }
        }

        public override string ToString()
        {
            return "FriendshipRepositoryChangeResponseFriendshipStatus{" + "following=" + following + ", followedBy=" +
                   followedBy + ", blocking=" + blocking + ", muting=" + muting + ", isPrivate=" + isPrivate +
                   ", incomingRequest=" + incomingRequest + ", outgoingRequest=" + outgoingRequest + ", isBestie=" +
                   isBestie + '}';
        }
    }
}