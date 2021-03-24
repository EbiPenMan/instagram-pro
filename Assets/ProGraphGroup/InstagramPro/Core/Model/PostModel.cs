using ProGraphGroup.InstagramPro.Core.Model.Enums;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class PostModel : BasePostModel
    {
        protected internal readonly string thumbnailUrl;
        protected internal string endCursor;
        protected internal bool hasNextPage;

        public PostModel(in string shortCode, in bool isid)
        {
            if (!isid)
            {
                this.shortCode = shortCode;
            }
            else
            {
                this.postId = shortCode;
            }

            this.thumbnailUrl = null;
        }

        public PostModel(in MediaItemType itemType, in string postId, in string displayUrl, in string thumbnailUrl,
            in string shortCode, in string postCaption, in string captionId, long timestamp, bool liked,
            bool bookmarked)
        {
            this.itemType = itemType;
            this.postId = postId;
            this.displayUrl = displayUrl;
            this.thumbnailUrl = thumbnailUrl;
            this.shortCode = shortCode;
            this.postCaption = postCaption;
            this.captionId = captionId;
            this.timestamp = timestamp;
            this.liked = liked;
            this.saved = bookmarked;
        }

        public virtual string ThumbnailUrl
        {
            get { return thumbnailUrl; }
        }

        public virtual string EndCursor
        {
            get { return endCursor; }
        }


        public virtual string PostCaption
        {
            set { this.postCaption = value; }
        }

        public virtual long Timestamp
        {
            set { this.timestamp = value; }
        }

        public virtual void setPageCursor(in bool hasNextPage, in string endCursor)
        {
            this.endCursor = endCursor;
            this.hasNextPage = hasNextPage;
        }

        public bool HasNextPage
        {
            get => hasNextPage;
            set => hasNextPage = value;
        }
    }
}