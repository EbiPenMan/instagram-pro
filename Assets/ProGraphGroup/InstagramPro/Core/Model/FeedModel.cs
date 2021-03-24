using System.Collections.Generic;
using ProGraphGroup.InstagramPro.Core.Model.Enums;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public sealed class FeedModel : PostModel
    {
        private readonly ProfileModel profileModel;
        private readonly long commentsCount;
        private long likesCount;
        private readonly long viewCount;
        private readonly IList<PostChild> sliderItems;
        private readonly int imageWidth;
        private readonly int imageHeight;
        private readonly string locationName;
        private readonly string locationId;
        private string adsId;

        public class Builder
        {
            internal ProfileModel profileModel;
            internal MediaItemType itemType;
            internal long viewCount;
            internal string postId;
            internal string displayUrl;
            internal string thumbnailUrl;
            internal string shortCode;
            internal string postCaption, captionId;
            internal long commentsCount;
            internal long timestamp;
            internal bool liked;
            internal bool bookmarked;
            internal long likesCount;
            internal string locationName;
            internal string locationId;
            internal IList<PostChild> sliderItems;
            internal int imageWidth;
            internal int imageHeight;
            internal string adsId;

            public virtual Builder setProfileModel(in ProfileModel profileModel)
            {
                this.profileModel = profileModel;
                return this;
            }

            public virtual Builder setItemType(in MediaItemType itemType)
            {
                this.itemType = itemType;
                return this;
            }

            public virtual Builder setViewCount(in long viewCount)
            {
                this.viewCount = viewCount;
                return this;
            }

            public virtual Builder setPostId(in string postId)
            {
                this.postId = postId;
                return this;
            }

            public virtual Builder setDisplayUrl(in string displayUrl)
            {
                this.displayUrl = displayUrl;
                return this;
            }

            public virtual Builder setThumbnailUrl(in string thumbnailUrl)
            {
                this.thumbnailUrl = thumbnailUrl;
                return this;
            }

            public virtual Builder setShortCode(in string shortCode)
            {
                this.shortCode = shortCode;
                return this;
            }

            public virtual Builder setPostCaption(in string postCaption)
            {
                this.postCaption = postCaption;
                return this;
            }

            public virtual Builder setCaptionId(in string captionId)
            {
                this.captionId = captionId;
                return this;
            }

            public virtual Builder setCommentsCount(in long commentsCount)
            {
                this.commentsCount = commentsCount;
                return this;
            }

            public virtual Builder setTimestamp(in long timestamp)
            {
                this.timestamp = timestamp;
                return this;
            }

            public virtual Builder setLiked(in bool liked)
            {
                this.liked = liked;
                return this;
            }

            public virtual Builder setBookmarked(in bool bookmarked)
            {
                this.bookmarked = bookmarked;
                return this;
            }

            public virtual Builder setLikesCount(in long likesCount)
            {
                this.likesCount = likesCount;
                return this;
            }

            public virtual Builder setLocationName(in string locationName)
            {
                this.locationName = locationName;
                return this;
            }

            public virtual Builder setLocationId(in string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public virtual Builder setSliderItems(in IList<PostChild> sliderItems)
            {
                this.sliderItems = sliderItems;
                return this;
            }

            public virtual Builder setImageHeight(in int imageHeight)
            {
                this.imageHeight = imageHeight;
                return this;
            }

            public virtual Builder setImageWidth(in int imageWidth)
            {
                this.imageWidth = imageWidth;
                return this;
            }

            public virtual Builder setAdsId(in string adsId)
            {
                this.adsId = adsId;
                return this;
            }

            public virtual FeedModel build()
            {
                return new FeedModel(profileModel, itemType, viewCount, postId, displayUrl, thumbnailUrl, shortCode,
                    postCaption, captionId, commentsCount, timestamp, liked, bookmarked, likesCount, locationName,
                    locationId, sliderItems, imageHeight, imageWidth, adsId);
            }
        }


        private FeedModel(in ProfileModel profileModel, in MediaItemType itemType, in long viewCount, in string postId,
            in string displayUrl, in string thumbnailUrl, in string shortCode, in string postCaption,
            in string captionId, in long commentsCount, in long timestamp, in bool liked, in bool bookmarked,
            in long likesCount, in string locationName, in string locationId, in IList<PostChild> sliderItems,
            in int imageHeight, in int imageWidth) : base(itemType, postId, displayUrl, thumbnailUrl, shortCode,
            postCaption, captionId, timestamp, liked, bookmarked)
        {
            this.profileModel = profileModel;
            this.commentsCount = commentsCount;
            this.likesCount = likesCount;
            this.viewCount = viewCount;
            this.locationName = locationName;
            this.locationId = locationId;
            this.sliderItems = sliderItems;
            this.imageHeight = imageHeight;
            this.imageWidth = imageWidth;
            this.adsId = "";
        }

        private FeedModel(in ProfileModel profileModel, in MediaItemType itemType, in long viewCount, in string postId,
            in string displayUrl, in string thumbnailUrl, in string shortCode, in string postCaption,
            in string captionId, in long commentsCount, in long timestamp, in bool liked, in bool bookmarked,
            in long likesCount, in string locationName, in string locationId, in IList<PostChild> sliderItems,
            in int imageHeight, in int imageWidth, in string adsId) : base(itemType, postId, displayUrl, thumbnailUrl,
            shortCode, postCaption, captionId, timestamp, liked, bookmarked)
        {
            this.profileModel = profileModel;
            this.commentsCount = commentsCount;
            this.likesCount = likesCount;
            this.viewCount = viewCount;
            this.locationName = locationName;
            this.locationId = locationId;
            this.sliderItems = sliderItems;
            this.imageHeight = imageHeight;
            this.imageWidth = imageWidth;
            this.adsId = adsId;
        }

        public ProfileModel ProfileModel
        {
            get { return profileModel; }
        }

        public IList<PostChild> SliderItems
        {
            get { return sliderItems; }
        }

        public long ViewCount
        {
            get { return viewCount; }
        }

        public long CommentsCount
        {
            get { return commentsCount; }
        }

        public long LikesCount
        {
            get { return likesCount; }
            set { this.likesCount = value; }
        }

        public int ImageWidth
        {
            get { return imageWidth; }
        }

        public int ImageHeight
        {
            get { return imageHeight; }
        }

        public string LocationName
        {
            get { return locationName; }
        }

        public string LocationId
        {
            get { return locationId; }
        }

        public bool Liked
        {
            set { this.liked = value; }
        }


        public bool Saved
        {
            set { this.saved = value; }
        }

        public string AdsId
        {
            get { return adsId; }
            set { this.adsId = value; }
        }


        public override string ToString()
        {
            return "FeedModel{" + "type=" + itemType + ", displayUrl=" + displayUrl + ", thumbnailUrl=" + thumbnailUrl +
                   ", commentsCount=" + commentsCount + ", viewCount=" + viewCount + ", imageWidth=" + imageWidth +
                   ", imageHeight=" + imageHeight + ", locationName='" + locationName + '\'' + ", locationId='" +
                   locationId + '\'' + '}';
        }
    }
}