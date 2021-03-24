using System;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public class TopicCluster
    {
        private string id;
        private string title;
        private string type;
        private bool canMute;
        private bool isMuted;
        private int rankedPosition;
        private FeedModel coverMedia;

        public TopicCluster(in string id, in string title, in string type, in bool canMute, in bool isMuted, in int rankedPosition, in FeedModel coverMedia)
        {
            this.id = id;
            this.title = title;
            this.type = type;
            this.canMute = canMute;
            this.isMuted = isMuted;
            this.rankedPosition = rankedPosition;
            this.coverMedia = coverMedia;
        }

        public virtual string Id
        {
            get
            {
                return id;
            }
        }

        public virtual string Title
        {
            get
            {
                return title;
            }
        }

        public virtual string Type
        {
            get
            {
                return type;
            }
        }

        public virtual bool CanMute
        {
            get
            {
                return canMute;
            }
        }

        public virtual bool Muted
        {
            get
            {
                return isMuted;
            }
        }

        public virtual int RankedPosition
        {
            get
            {
                return rankedPosition;
            }
        }

        public virtual FeedModel CoverMedia
        {
            get
            {
                return coverMedia;
            }
        }
    }
}