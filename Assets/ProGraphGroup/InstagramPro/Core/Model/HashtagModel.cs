using System;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public sealed class HashtagModel
    {
        private readonly bool following;
        private readonly long postCount;
        private readonly string id;
        private readonly string name;
        private readonly string sdProfilePic;

        public HashtagModel(in string id, in string name, in string sdProfilePic, in long postCount, in bool following)
        {
            this.id = id;
            this.name = name;
            this.sdProfilePic = sdProfilePic;
            this.postCount = postCount;
            this.following = following;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string SdProfilePic
        {
            get
            {
                return sdProfilePic;
            }
        }

        public long? PostCount
        {
            get
            {
                return postCount;
            }
        }

        public bool Following
        {
            get
            {
                return following;
            }
        }
    }
}