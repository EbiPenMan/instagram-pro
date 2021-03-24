using System;
using ProGraphGroup.Utility;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public sealed class FeedStoryModel
    {
        private readonly string storyMediaId;
        private readonly ProfileModel profileModel;
        private readonly StoryModel firstStoryModel;
        private bool? fullyRead;
        private readonly bool isLive, isBestie;
        private readonly long timestamp;
        private readonly int mediaCount;

        public FeedStoryModel(in string storyMediaId, in ProfileModel profileModel, in bool fullyRead, in long timestamp, in StoryModel firstStoryModel, in int mediaCount, in bool isLive, in bool isBestie)
        {
            this.storyMediaId = storyMediaId;
            this.profileModel = profileModel;
            this.fullyRead = fullyRead;
            this.timestamp = timestamp;
            this.firstStoryModel = firstStoryModel;
            this.mediaCount = mediaCount;
            this.isLive = isLive;
            this.isBestie = isBestie;
        }

        public string StoryMediaId
        {
            get
            {
                return storyMediaId;
            }
        }

        public long Timestamp
        {
            get
            {
                return timestamp;
            }
        }


        public string DateTime
        {
            get { return GeneralUtils.JavaTimeStampToDateTime(timestamp).ToString(); }
        }

        public int MediaCount
        {
            get
            {
                return mediaCount;
            }
        }

        public ProfileModel ProfileModel
        {
            get
            {
                return profileModel;
            }
        }

//    public void setFirstStoryModel(final StoryModel firstStoryModel) {
//        this.firstStoryModel = firstStoryModel;
//    }

        public StoryModel FirstStoryModel
        {
            get
            {
                return firstStoryModel;
            }
        }

        public bool? isFullyRead()
        {
            return fullyRead;
        }

        public void setFullyRead(in bool fullyRead)
        {
            this.fullyRead = fullyRead;
        }

        public bool Live
        {
            get
            {
                return isLive;
            }
        }

        public bool Bestie
        {
            get
            {
                return isBestie;
            }
        }
    }
}