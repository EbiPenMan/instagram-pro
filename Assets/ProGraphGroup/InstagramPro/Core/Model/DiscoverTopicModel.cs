using System;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public sealed class DiscoverTopicModel
    {
        private readonly string[] id, name;
        private readonly string rankToken;

        public DiscoverTopicModel(in string[] id, in string[] name, in string rankToken)
        {
            this.id = id;
            this.name = name;
            this.rankToken = rankToken;
        }

        public string[] Ids
        {
            get
            {
                return id;
            }
        }

        public string[] Names
        {
            get
            {
                return name;
            }
        }

        public string Token
        {
            get
            {
                return rankToken;
            }
        }
    }
}