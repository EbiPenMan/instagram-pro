using System;
using ProGraphGroup.InstagramPro.Core.Model.Enums;
using ProGraphGroup.Utility;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    public sealed class NotificationModel
    {
        private readonly string id;
        private readonly string userId;
        private readonly string username;
        private readonly string profilePicUrl;
        private readonly string postId;
        private readonly string previewUrl;
        private readonly NotificationType type;
        private readonly string text;
        private readonly long timestamp;

        public NotificationModel(in string id, in string text, in long timestamp, in string userId, in string username, in string profilePicUrl, in string postId, in string previewUrl, in NotificationType type)
        {
            this.id = id;
            this.text = TextUtils.hasMentions(text) ? TextUtils.getMentionText(text) : text;
            this.timestamp = timestamp;
            this.userId = userId;
            this.username = username;
            this.profilePicUrl = profilePicUrl;
            this.postId = postId;
            this.previewUrl = previewUrl;
            this.type = type;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
        }

        public long Timestamp
        {
            get
            {
                return timestamp;
            }
        }

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @NonNull public String getDateTime()
        public string DateTime
        {
            get
            {
                return GeneralUtils.UnixTimeStampToDateTime(timestamp).ToString();
            }
        }

        public string UserId
        {
            get
            {
                return userId;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
        }

        public string ProfilePic
        {
            get
            {
                return profilePicUrl;
            }
        }

        public string PostId
        {
            get
            {
                return postId;
            }
        }

        public string PreviewPic
        {
            get
            {
                return previewUrl;
            }
        }

        public NotificationType Type
        {
            get
            {
                return type;
            }
        }
    }
}