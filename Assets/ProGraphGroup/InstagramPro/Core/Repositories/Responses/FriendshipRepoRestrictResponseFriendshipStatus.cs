namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class FriendshipRepoRestrictResponseFriendshipStatus : FriendshipRepoChangeResponseFriendshipStatus
    {
        private bool isRestricted;

        public FriendshipRepoRestrictResponseFriendshipStatus(in bool following, in bool followedBy, in bool blocking,
            in bool muting, in bool isPrivate, in bool incomingRequest, in bool outgoingRequest, in bool isBestie,
            in bool isRestricted) : base(following, followedBy, blocking, muting, isPrivate, incomingRequest,
            outgoingRequest, isBestie)
        {
            this.isRestricted = isRestricted;
        }

        public virtual bool Restricted
        {
            get { return isRestricted; }
        }

        public override string ToString()
        {
            return "FriendshipRepoRestrictResponseFriendshipStatus{" + "following=" + Following + ", followedBy=" +
                   FollowedBy + ", blocking=" + Blocking + ", muting=" + Muting + ", isPrivate=" + Private +
                   ", incomingRequest=" + IncomingRequest + ", outgoingRequest=" + OutgoingRequest + ", isBestie=" +
                   Bestie + ", isRestricted=" + Restricted + '}';
        }
    }
}