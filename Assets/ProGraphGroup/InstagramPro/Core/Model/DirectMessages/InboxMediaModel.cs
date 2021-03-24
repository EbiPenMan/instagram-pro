using ProGraphGroup.InstagramPro.Core.Model.Enums;

namespace ProGraphGroup.InstagramPro.Core.Model.DirectMessages
{
    public sealed class InboxMediaModel
    {
        private readonly MediaItemType mediaType;
        private readonly string mediaId;
        private readonly string displayUrl;

        public InboxMediaModel(in MediaItemType mediaType, in string mediaId, in string displayUrl)
        {
            this.mediaType = mediaType;
            this.mediaId = mediaId;
            this.displayUrl = displayUrl;
        }

        public MediaItemType MediaType
        {
            get
            {
                return mediaType;
            }
        }

        public string MediaId
        {
            get
            {
                return mediaId;
            }
        }

        public string DisplayUrl
        {
            get
            {
                return displayUrl;
            }
        }
    }

}