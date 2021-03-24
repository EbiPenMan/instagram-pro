using System.Collections.Generic;
using ProGraphGroup.InstagramPro.Core.Model;

namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class PostsFetchResponse
    {
        private IList<FeedModel> feedModels;
        private bool hasNextPage;
        private string nextCursor;

        public PostsFetchResponse(in IList<FeedModel> feedModels, in bool hasNextPage, in string nextCursor)
        {
            this.feedModels = feedModels;
            this.hasNextPage = hasNextPage;
            this.nextCursor = nextCursor;
        }

        public bool HasNextPage
        {
            get => hasNextPage;
            set => hasNextPage = value;
        }

        public virtual IList<FeedModel> FeedModels
        {
            get
            {
                return feedModels;
            }
        }



        public virtual string NextCursor
        {
            get
            {
                return nextCursor;
            }
        }
    }
}