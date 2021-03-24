using System;
using System.Collections.Generic;
using ProGraphGroup.Utility;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public class CommentModel
    {
        private readonly ProfileModel profileModel;
        private readonly string id;
        private readonly string text;
        private long likes;
        private readonly long timestamp;
        private IList<CommentModel> childCommentModels;
        private bool liked, hasNextPage;
        private string endCursor;

        public CommentModel(in string id, in string text, in long timestamp, in long likes, in bool liked, in ProfileModel profileModel)
        {
            this.id = id;
            this.text = text;
            this.likes = likes;
            this.liked = liked;
            this.timestamp = timestamp;
            this.profileModel = profileModel;
        }

        public bool HasNextPage
        {
            get => hasNextPage;
            set => hasNextPage = value;
        }

        public virtual string Id
        {
            get
            {
                return id;
            }
        }

        public virtual string Text
        {
            get
            {
                return text;
            }
        }

        public virtual string DateTime
        {
            get { return GeneralUtils.UnixTimeStampToDateTime(timestamp).ToString(); }
        }

        public virtual long Likes
        {
            get
            {
                return likes;
            }
        }

        public virtual bool Liked
        {
            get
            {
                return liked;
            }
            set
            {
                this.likes = value ? likes + 1 : likes - 1;
                this.liked = value;
            }
        }


        public virtual ProfileModel ProfileModel
        {
            get
            {
                return profileModel;
            }
        }

        public virtual IList<CommentModel> ChildCommentModels
        {
            get
            {
                return childCommentModels;
            }
            set
            {
                this.childCommentModels = value;
            }
        }


        public virtual void setPageCursor(in bool hasNextPage, in string endCursor)
        {
            this.hasNextPage = hasNextPage;
            this.endCursor = endCursor;
        }



        public virtual string EndCursor
        {
            get
            {
                return endCursor;
            }
        }

    }
}