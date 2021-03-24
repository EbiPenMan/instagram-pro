using System;
using ProGraphGroup.Utility;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public sealed class HighlightModel
    {
        private readonly string title;
        private readonly string id;
        private readonly string thumbnailUrl;
        private readonly long timestamp;
        private readonly int mediaCount;

        public HighlightModel(in string title, in string id, in string thumbnailUrl, in long timestamp, in int mediaCount)
        {
            this.title = title;
            this.id = id;
            this.thumbnailUrl = thumbnailUrl;
            this.timestamp = timestamp;
            this.mediaCount = mediaCount;
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string ThumbnailUrl
        {
            get
            {
                return thumbnailUrl;
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
            get
            {
                return GeneralUtils.JavaTimeStampToDateTime(timestamp).ToString();
            }
        }

        public int MediaCount
        {
            get
            {
                return mediaCount;
            }
        }
    }
}