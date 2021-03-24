using System;
using ProGraphGroup.InstagramPro.Core.Model.Enums;
using ProGraphGroup.InstagramPro.Core.Model.Stickers;

namespace ProGraphGroup.InstagramPro.Core.Model
{
    [Serializable]
    public sealed class StoryModel
    {
        private readonly string storyMediaId;
        private readonly string storyUrl;
        private string thumbnail;
        private readonly string username;
        private readonly string userId;
        private readonly MediaItemType itemType;
        private readonly long timestamp;
        private string videoUrl;
        private string tappableShortCode;
        private string tappableId;
        private string spotify;
        private PollModel poll;
        private QuestionModel question;
        private SliderModel slider;
        private QuizModel quiz;
        private SwipeUpModel swipeUp;
        private string[] mentions;
        private int position;
        private bool isCurrentSlide = false;
        private readonly bool canReply;

        public StoryModel(in string storyMediaId, in string storyUrl, in string thumbnail, in MediaItemType itemType, in long timestamp, in string username, in string userId, in bool canReply)
        {
            this.storyMediaId = storyMediaId;
            this.storyUrl = storyUrl;
            this.thumbnail = thumbnail;
            this.itemType = itemType;
            this.timestamp = timestamp;
            this.username = username;
            this.userId = userId;
            this.canReply = canReply;
        }

        public string StoryMediaId => storyMediaId;

        public string StoryUrl => storyUrl;

        public string Thumbnail
        {
            get => thumbnail;
            set => thumbnail = value;
        }

        public string Username => username;

        public string UserId => userId;

        public MediaItemType ItemType => itemType;

        public long Timestamp => timestamp;

        public string VideoUrl
        {
            get => videoUrl;
            set => videoUrl = value;
        }

        public string TappableShortCode
        {
            get => tappableShortCode;
            set => tappableShortCode = value;
        }

        public string TappableId
        {
            get => tappableId;
            set => tappableId = value;
        }

        public string Spotify
        {
            get => spotify;
            set => spotify = value;
        }

        public PollModel Poll
        {
            get => poll;
            set => poll = value;
        }

        public QuestionModel Question
        {
            get => question;
            set => question = value;
        }

        public SliderModel Slider
        {
            get => slider;
            set => slider = value;
        }

        public QuizModel Quiz
        {
            get => quiz;
            set => quiz = value;
        }

        public SwipeUpModel SwipeUp
        {
            get => swipeUp;
            set => swipeUp = value;
        }

        public string[] Mentions
        {
            get => mentions;
            set => mentions = value;
        }

        public int Position
        {
            get => position;
            set => position = value;
        }

        public bool IsCurrentSlide
        {
            get => isCurrentSlide;
            set => isCurrentSlide = value;
        }

        public bool CanReply => canReply;
    }
}