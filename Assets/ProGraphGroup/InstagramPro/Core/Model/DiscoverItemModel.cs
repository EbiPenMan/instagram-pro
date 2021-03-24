using ProGraphGroup.InstagramPro.Core.Model.Enums;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public sealed class DiscoverItemModel : BasePostModel
    {
        private bool moreAvailable;
        private string nextMaxId;

        public DiscoverItemModel(in MediaItemType mediaType, in string postId, in string shortCode, in string thumbnail)
        {
            this.postId = postId;
            this.itemType = mediaType;
            this.shortCode = shortCode;
            this.displayUrl = thumbnail;
        }


        public void setMore(in bool moreAvailable, in string nextMaxId)
        {
            this.moreAvailable = moreAvailable;
            this.nextMaxId = nextMaxId;
        }

        public bool hasMore()
        {
            return moreAvailable;
        }

        public string NextMaxId
        {
            get
            {
                return nextMaxId;
            }
        }
    }
}