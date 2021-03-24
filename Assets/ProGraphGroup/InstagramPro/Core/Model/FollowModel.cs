using System;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public sealed class FollowModel
    {
        private readonly string id, username, fullName, profilePicUrl;
        private string endCursor;
        private bool hasNextPage, isShown = true;

        public FollowModel(in string id, in string username, in string fullName, in string profilePicUrl)
        {
            this.id = id;
            this.username = username;
            this.fullName = fullName;
            this.profilePicUrl = profilePicUrl;
        }

        public bool HasNextPage
        {
            get => hasNextPage;
            set => hasNextPage = value;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
        }

        public string ProfilePicUrl
        {
            get
            {
                return profilePicUrl;
            }
        }

        public bool Shown
        {
            get
            {
                return isShown;
            }
            set
            {
                isShown = value;
            }
        }


        public void setPageCursor(in bool hasNextPage, in string endCursor)
        {
            this.endCursor = endCursor;
            this.hasNextPage = hasNextPage;
        }


        public string EndCursor
        {
            get
            {
                return endCursor;
            }
        }


        public override bool Equals(object obj)
        {
            if (obj is FollowModel)
            {
                FollowModel model = (FollowModel) obj;
                if (model.Id.Equals(id) && model.Username.Equals(username))
                {
                    return true;
                }
            }
            return base.Equals(obj);
        }
    }
    
    
    
}