using System;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public sealed class ProfileModel
    {
        private readonly bool isPrivate, reallyPrivate, isVerified, following, follower, restricted, blocked, requested;
        private readonly long postCount, followersCount, followingCount;
        private readonly string id, username, name, biography, url, sdProfilePic, hdProfilePic;

        public ProfileModel(in bool isPrivate, in bool reallyPrivate, in bool isVerified, in string id, in string username, in string name, in string biography, in string url, in string sdProfilePic, in string hdProfilePic, in long postCount, in long followersCount, in long followingCount, in bool following, in bool follower, in bool restricted, in bool blocked, in bool requested)
        {
            this.isPrivate = isPrivate;
            this.reallyPrivate = reallyPrivate;
            this.isVerified = isVerified;
            this.id = id;
            this.url = url;
            this.name = name;
            this.username = username;
            this.biography = biography;
            this.sdProfilePic = sdProfilePic;
            this.hdProfilePic = hdProfilePic;
            this.postCount = postCount;
            this.followersCount = followersCount;
            this.followingCount = followingCount;
            this.following = following;
            this.follower = follower;
            this.restricted = restricted;
            this.blocked = blocked;
            this.requested = requested;
        }

        public static ProfileModel DefaultProfileModel
        {
            get
            {
                return new ProfileModel(false, false, false, null, null, null, null, null, null, null, 0, 0, 0, false, false, false, false, false);
            }
        }

        public static ProfileModel getDefaultProfileModel(in string userId)
        {
            return new ProfileModel(false, false, false, userId, null, null, null, null, null, null, 0, 0, 0, false, false, false, false, false);
        }

        public static ProfileModel getDefaultProfileModel(in string userId, in string username)
        {
            return new ProfileModel(false, false, false, userId, username, null, null, null, null, null, 0, 0, 0, false, false, false, false, false);
        }

        public bool IsPrivate => isPrivate;

        public bool ReallyPrivate => reallyPrivate;

        public bool IsVerified => isVerified;

        public bool Following => following;

        public bool Follower => follower;

        public bool Restricted => restricted;

        public bool Blocked => blocked;

        public bool Requested => requested;

        public long PostCount => postCount;

        public long FollowersCount => followersCount;

        public long FollowingCount => followingCount;

        public string Id => id;

        public string Username => username;

        public string Name => name;

        public string Biography => biography;

        public string Url => url;

        public string SdProfilePic => sdProfilePic;

        public string HdProfilePic => hdProfilePic;
    }
}